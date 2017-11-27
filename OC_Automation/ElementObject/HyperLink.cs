using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace OC_Automation.ElementObject
{
    public class HyperLink : IClickable
    {
        private readonly HtmlHyperlink _hyperlink;

        public HyperLink(HtmlHyperlink hyperlink)
        {
            _hyperlink = hyperlink;
        }

        public HyperLink(BrowserWindow browserWindow)
        {
            _hyperlink = new HtmlHyperlink(browserWindow);

            _hyperlink.TechnologyName = "Web";
            _hyperlink.SearchProperties.Add("ControlType", "Hyperlink");
        }

        public HyperLink(BrowserWindow browserWindow, string id)
        {
            _hyperlink = new HtmlHyperlink(browserWindow);
            _hyperlink.SearchProperties.Add("Id", id);
        }

        public HyperLink(UITestControl parent)
        {
            var children = parent.GetChildren();
            foreach (var child in children)
            {
                if (child.ControlType == "Hyperlink")
                {
                    _hyperlink = (HtmlHyperlink)child;
                    break;
                }
            }
        }

        public void SetInnerText(string tag)
        {
            _hyperlink.SearchProperties.Add("InnerText", tag);
        }

        public void Click()
        {
            Mouse.Click(_hyperlink);
        }
    }
}