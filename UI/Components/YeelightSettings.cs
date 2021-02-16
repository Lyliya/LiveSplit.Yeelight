//using NAudio.Wave;
using System;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class YeelightSettings : UserControl
    {
        public string Split { get; set; }
        public string SplitAheadGaining { get; set; }
        public string SplitAheadLosing { get; set; }
        public string SplitBehindGaining { get; set; }
        public string SplitBehindLosing { get; set; }
        public string BestSegment { get; set; }
        public string UndoSplit { get; set; }
        public string SkipSplit { get; set; }
        public string PersonalBest { get; set; }
        public string NotAPersonalBest { get; set; }
        public string Reset { get; set; }
        public string Pause { get; set; }
        public string Resume { get; set; }
        public string StartTimer { get; set; }

        public YeelightSettings()
        {
            InitializeComponent();

            Split =
            SplitAheadGaining =
            SplitAheadLosing =
            SplitBehindGaining =
            SplitBehindLosing =
            BestSegment =
            UndoSplit =
            SkipSplit =
            PersonalBest =
            NotAPersonalBest =
            Reset =
            Pause =
            Resume =
            StartTimer = "";

            //for (int i = 0; i < WaveOut.DeviceCount; ++i)
                //cbOutputDevice.Items.Add(WaveOut.GetCapabilities(i));

            txtSplitPath.DataBindings.Add("Text", this, "Split");
            txtSplitAheadGaining.DataBindings.Add("Text", this, "SplitAheadGaining");
            txtSplitAheadLosing.DataBindings.Add("Text", this, "SplitAheadLosing");
            txtSplitBehindGaining.DataBindings.Add("Text", this, "SplitBehindGaining");
            txtSplitBehindLosing.DataBindings.Add("Text", this, "SplitBehindLosing");
            txtBestSegment.DataBindings.Add("Text", this, "BestSegment");
            txtUndo.DataBindings.Add("Text", this, "UndoSplit");
            txtSkip.DataBindings.Add("Text", this, "SkipSplit");
            txtPersonalBest.DataBindings.Add("Text", this, "PersonalBest");
            txtNotAPersonalBest.DataBindings.Add("Text", this, "NotAPersonalBest");
            txtReset.DataBindings.Add("Text", this, "Reset");
            txtPause.DataBindings.Add("Text", this, "Pause");
            txtResume.DataBindings.Add("Text", this, "Resume");
            txtStartTimer.DataBindings.Add("Text", this, "StartTimer");
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;

            Split = SettingsHelper.ParseString(element["Split"]);
            SplitAheadGaining = SettingsHelper.ParseString(element["SplitAheadGaining"]);
            SplitAheadLosing = SettingsHelper.ParseString(element["SplitAheadLosing"]);
            SplitBehindGaining = SettingsHelper.ParseString(element["SplitBehindGaining"]);
            SplitBehindLosing = SettingsHelper.ParseString(element["SplitBehindLosing"]);
            BestSegment = SettingsHelper.ParseString(element["BestSegment"]);
            UndoSplit = SettingsHelper.ParseString(element["UndoSplit"]);
            SkipSplit = SettingsHelper.ParseString(element["SkipSplit"]);
            PersonalBest = SettingsHelper.ParseString(element["PersonalBest"]);
            NotAPersonalBest = SettingsHelper.ParseString(element["NotAPersonalBest"]);
            Reset = SettingsHelper.ParseString(element["Reset"]);
            Pause = SettingsHelper.ParseString(element["Pause"]);
            Resume = SettingsHelper.ParseString(element["Resume"]);
            StartTimer = SettingsHelper.ParseString(element["StartTimer"]);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.6") ^
            SettingsHelper.CreateSetting(document, parent, "Split", Split) ^
            SettingsHelper.CreateSetting(document, parent, "SplitAheadGaining", SplitAheadGaining) ^
            SettingsHelper.CreateSetting(document, parent, "SplitAheadLosing", SplitAheadLosing) ^
            SettingsHelper.CreateSetting(document, parent, "SplitBehindGaining", SplitBehindGaining) ^
            SettingsHelper.CreateSetting(document, parent, "SplitBehindLosing", SplitBehindLosing) ^
            SettingsHelper.CreateSetting(document, parent, "BestSegment", BestSegment) ^
            SettingsHelper.CreateSetting(document, parent, "UndoSplit", UndoSplit) ^
            SettingsHelper.CreateSetting(document, parent, "SkipSplit", SkipSplit) ^
            SettingsHelper.CreateSetting(document, parent, "PersonalBest", PersonalBest) ^
            SettingsHelper.CreateSetting(document, parent, "NotAPersonalBest", NotAPersonalBest) ^
            SettingsHelper.CreateSetting(document, parent, "Reset", Reset) ^
            SettingsHelper.CreateSetting(document, parent, "Pause", Pause) ^
            SettingsHelper.CreateSetting(document, parent, "Resume", Resume) ^
            SettingsHelper.CreateSetting(document, parent, "StartTimer", StartTimer);
        }
    }
}
