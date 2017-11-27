using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace OC_Automation.ElementObject
{
    public class Button : IClickable
    {
        private readonly HtmlButton _button;

        public Button(HtmlButton button)
        {
            _button = button;
        }

        public Button(BrowserWindow browserWindow)
        {
            _button = new HtmlButton(browserWindow) { TechnologyName = "Web" };

            _button.SearchProperties.Add("ControlType", "Button");
        }

        public Button(BrowserWindow browserWindow, string id)
        {
            _button = new HtmlButton(browserWindow);
            _button.SearchProperties.Add("Id", id);
        }

        public Button(UITestControl parent)
        {
            var children = parent.GetChildren();
            foreach (var child in children)
            {
                if (child.ControlType == "Button")
                {
                    _button = (HtmlButton)child;
                    break;
                }
            }
        }

        // Todo: Can abstract further just getting this working mh
        public void SetInnerText(string tag)
        {
            _button.SearchProperties.Add("InnerText", tag);
        }

        public void FindTagInstance(string tag)
        {
            _button.SearchProperties.Add("TagInstance", tag);
        }

        public void Click()
        {
            Mouse.Click(_button);
        }
    }
}
