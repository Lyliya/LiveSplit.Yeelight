using LiveSplit.Model;
using YeelightAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;
using System.Linq;

namespace LiveSplit.UI.Components
{
    public class YeelightComponent : LogicComponent, IDeactivatableComponent
    {
        public override string ComponentName => "Yeelight Control";

        public bool Activated { get; set; }

        private LiveSplitState State { get; set; }
        private YeelightSettings Settings { get; set; }

        private List<Device> Lights;

        private static Color HexToColor(string hexString)
        {
            //replace # occurences
            if (hexString.IndexOf('#') != -1)
                hexString = hexString.Replace("#", "");

            int r, g, b = 0;

            r = int.Parse(hexString.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            g = int.Parse(hexString.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            b = int.Parse(hexString.Substring(4, 2), NumberStyles.AllowHexSpecifier);

            return Color.FromArgb(r, g, b);
        }

        public YeelightComponent(LiveSplitState state)
        {
            Activated = true;

            State = state;
            Settings = new YeelightSettings();

            Lights = new List<Device>();

            State.OnStart += State_OnStart;
            State.OnSplit += State_OnSplit;
            State.OnSkipSplit += State_OnSkipSplit;
            State.OnUndoSplit += State_OnUndoSplit;
            State.OnPause += State_OnPause;
            State.OnResume += State_OnResume;
            State.OnReset += State_OnReset;
        }

        private void stop()
        {
            for (int i = 0; i < Lights.Count; i++)
            {
                Lights[i].SetPower(false);
                Lights[i].Disconnect();
            }
            Lights.Clear();
        }

        public override async void Dispose()
        {
            State.OnStart -= State_OnStart;
            State.OnSplit -= State_OnSplit;
            State.OnSkipSplit -= State_OnSkipSplit;
            State.OnUndoSplit -= State_OnUndoSplit;
            State.OnPause -= State_OnPause;
            State.OnResume -= State_OnResume;
            State.OnReset -= State_OnReset;

            stop();
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return Settings;
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public override void SetSettings(XmlNode settings)
        {
            Settings.SetSettings(settings);
            InitLight();
        }

        private void State_OnStart(object sender, EventArgs e)
        {
            if (Settings.StartTimer?[0] != '#') return;
            Color color = HexToColor(Settings.StartTimer);

            for (int i = 0; i < Lights.Count; i++)
            {
                Lights[i].SetRGBColor(color.R, color.G, color.B);
            }
        }

        private void State_OnSplit(object sender, EventArgs e)
        {
            if (State.CurrentPhase == TimerPhase.Ended)
            {
                if (State.Run.Last().PersonalBestSplitTime[State.CurrentTimingMethod] == null || State.Run.Last().SplitTime[State.CurrentTimingMethod] < State.Run.Last().PersonalBestSplitTime[State.CurrentTimingMethod])
                {
                    //This is a PB
                    if (Settings.PersonalBest?[0] != '#') return;
                    Color color = HexToColor(Settings.PersonalBest);

                    for (int i = 0; i < Lights.Count; i++)
                    {
                        Lights[i].SetRGBColor(color.R, color.G, color.B);
                    }
                }
                else
                {
                    //This is not a PB
                    if (Settings.NotAPersonalBest?[0] != '#') return;
                    Color color = HexToColor(Settings.NotAPersonalBest);

                    for (int i = 0; i < Lights.Count; i++)
                    {
                        Lights[i].SetRGBColor(color.R, color.G, color.B);
                    }
                }
            }
            else
            {
                var path = string.Empty;

                var splitIndex = State.CurrentSplitIndex - 1;
                var timeDifference = State.Run[splitIndex].SplitTime[State.CurrentTimingMethod] - State.Run[splitIndex].Comparisons[State.CurrentComparison][State.CurrentTimingMethod];

                if (timeDifference != null)
                {
                    if (timeDifference < TimeSpan.Zero)
                    {
                        // Ahead Gain (vert foncé)
                        path = Settings.SplitAheadGaining;

                        if (LiveSplitStateHelper.GetPreviousSegmentDelta(State, splitIndex, State.CurrentComparison, State.CurrentTimingMethod) > TimeSpan.Zero)
                        {
                            // Ahead Losing (vert clair)
                            path = Settings.SplitAheadLosing;
                        }
                    }
                    else
                    {
                        // Behind Losing (rouge clair)
                        path = Settings.SplitBehindLosing;

                        if (LiveSplitStateHelper.GetPreviousSegmentDelta(State, splitIndex, State.CurrentComparison, State.CurrentTimingMethod) < TimeSpan.Zero)
                        {
                            // Behind losing (rouge foncé)
                            path = Settings.SplitBehindGaining;
                        }
                    }
                }

                //Check for best segment
                TimeSpan? curSegment = LiveSplitStateHelper.GetPreviousSegmentTime(State, splitIndex, State.CurrentTimingMethod);

                if (curSegment != null)
                {
                    if (State.Run[splitIndex].BestSegmentTime[State.CurrentTimingMethod] == null || curSegment < State.Run[splitIndex].BestSegmentTime[State.CurrentTimingMethod])
                    {
                        // Gold (doré)
                        path = Settings.BestSegment;
                    }
                }

                if (string.IsNullOrEmpty(path))
                    path = Settings.Split;

                if (path[0] != '#') return;
                Color color = HexToColor(path);

                for (int i = 0; i < Lights.Count; i++)
                {
                    Lights[i].SetRGBColor(color.R, color.G, color.B);
                }
            }
        }

        private void State_OnSkipSplit(object sender, EventArgs e)
        {
            if (Settings.SkipSplit?[0] != '#') return;
            Color color = HexToColor(Settings.SkipSplit);

            for (int i = 0; i < Lights.Count; i++)
            {
                Lights[i].SetRGBColor(color.R, color.G, color.B);
            }
        }

        private void State_OnUndoSplit(object sender, EventArgs e)
        {
            if (Settings.UndoSplit?[0] != '#') return;
            Color color = HexToColor(Settings.UndoSplit);

            for (int i = 0; i < Lights.Count; i++)
            {
                Lights[i].SetRGBColor(color.R, color.G, color.B);
            }
        }

        private void State_OnPause(object sender, EventArgs e)
        {
            if (Settings.Pause?[0] != '#') return;
            Color color = HexToColor(Settings.Pause);

            for (int i = 0; i < Lights.Count; i++)
            {
                Lights[i].SetRGBColor(color.R, color.G, color.B);
            }
        }

        private void State_OnResume(object sender, EventArgs e)
        {
            if (Settings.Resume?[0] != '#') return;
            Color color = HexToColor(Settings.Resume);

            for (int i = 0; i < Lights.Count; i++)
            {
                Lights[i].SetRGBColor(color.R, color.G, color.B);
            }
        }

        private void State_OnReset(object sender, TimerPhase e)
        {
            if (e != TimerPhase.Ended)
            {
                if (Settings.Reset?[0] != '#') return;
                Color color = HexToColor(Settings.Reset);

                for (int i = 0; i < Lights.Count; i++)
                {
                    Lights[i].SetRGBColor(color.R, color.G, color.B);
                }
            }
        }

        private async void InitLight()
        {
            string[] ips = Settings.Split.Split(',');

            if (ips.Length == 0) return;

            for (int i = 0; i < Lights.Count; i++)
            {
                await Lights[i].SetPower(false);
                Lights[i].Disconnect();
            }

            Lights.Clear();

            for (int i = 0; i < ips.Length; i++)
            {
                Device tmp = new Device(ips[i]);
                await tmp.Connect();
                await tmp.SetPower(true);
                await tmp.SetRGBColor(128, 128, 128);
                Lights.Add(tmp);
            }
        }

        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();
    }
}
