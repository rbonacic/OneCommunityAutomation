using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace OneCommunity_Automation.ElementObject
{
    public class Label : IClickable
    {
        private readonly HtmlLabel _label;

        public Label(HtmlLabel label)
        {
            _label = label;
        }

        public Label(BrowserWindow browserWindow)
        {
            _label = new HtmlLabel(browserWindow);

            _label.TechnologyName = "Web";
            _label.SearchProperties.Add("ControlType", "Label");
        }

        public Label(BrowserWindow browserWindow, string id)
        {
            _label = new HtmlLabel(browserWindow);
            _label.SearchProperties.Add("Id", id);
        }

        public Label(UITestControl parent)
        {
            var children = parent.GetChildren();
            foreach (var child in children)
            {
                if (child.ControlType == "Label")
                {
                    _label = (HtmlLabel)child;
                    break;
                }
            }
        }

        public void SetInnerText(string tag)
        {
            _label.SearchProperties.Add("InnerText", tag);
        }

        public void Click()
        {
            Mouse.Click(_label);
        }
    }
}