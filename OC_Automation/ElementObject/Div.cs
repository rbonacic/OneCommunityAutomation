using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace OC_Automation.ElementObject
{
    public class Div : IClickable
    {
        private readonly HtmlDiv _div;

        private int Height { get; set; }

        private int Width { get; set; }

        public Div(HtmlDiv div)
        {
            _div = div;
        }

        public Div(BrowserWindow browserWindow)
        {
            _div = new HtmlDiv(browserWindow);

            _div.TechnologyName = "Web";
            _div.SearchProperties.Add("ControlType", "Pane");
        }

        public Div(BrowserWindow browserWindow, string id)
        {
            _div = new HtmlDiv(browserWindow);
            _div.SearchProperties.Add("Id", id);
        }

        public Div(UITestControl parent)
        {
            var children = parent.GetChildren();
            foreach (var child in children)
            {
                if (child.ControlType == "Pane")
                {
                    _div = (HtmlDiv)child;
                    break;
                }
            }
        }

        public void SetInnerText(string tag)
        {
            _div.SearchProperties.Add("InnerText", tag);
        }

        public void MoveMouse(int width, int height)
        {
            this.Width = width;
            this.Height = height;

            Mouse.Move(_div, new Point(width, height));
        }

        public void Click()
        {
            Mouse.Click(_div);
        }
    }
}
