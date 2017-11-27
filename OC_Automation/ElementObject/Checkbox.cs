using HtmlElements.Elements;
using Microsoft.VisualStudio.Services.Client.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using static Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using BrowserWindow = Microsoft.VisualStudio.TestTools.UITesting.BrowserWindow;
using HtmlCheckBox = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls.HtmlCheckBox;


namespace OC_Automation.ElementObject
{
    public class Checkbox : IClickable
    {
        private readonly HtmlCheckBox _checkBox;

        public Checkbox(HtmlCheckBox button)
        {
            _checkBox = button;
        }

        public Checkbox(BrowserWindow browserWindow)
        {
            _checkBox = new HtmlCheckBox(browserWindow) { TechnologyName = "Web" };

            _checkBox.SearchProperties.Add("ControlType", "CheckBox");
        }

        public Checkbox(BrowserWindow browserWindow, string id)
        {
            _checkBox = new HtmlCheckBox(browserWindow);
            _checkBox.SearchProperties.Add("Id", id);
        }

        public Checkbox(UITestControl parent)
        {
            var children = parent.GetChildren();
            foreach (var child in children)
            {
                if (child.ControlType == "CheckBox")
                {
                    _checkBox = (HtmlCheckBox)child;
                    break;
                }
            }
        }

        public void SetInnerText(string tag)
        {
            _checkBox.SearchProperties.Add("InnerText", tag);
        }

        public void Click()
        {
            Mouse.Click(_checkBox);
        }
    }
}