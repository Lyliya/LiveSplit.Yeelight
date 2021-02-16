using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;

[assembly: ComponentFactory(typeof(YeelightFactory))]

namespace LiveSplit.UI.Components
{
    public class YeelightFactory : IComponentFactory
    {
        public string ComponentName => "Yeelight Control";

        public string Description => "Control Yeelight light";

        public ComponentCategory Category => ComponentCategory.Control;

        public IComponent Create(LiveSplitState state) => new YeelightComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "";

        public Version Version => Version.Parse("1.0.0");
    }
}
