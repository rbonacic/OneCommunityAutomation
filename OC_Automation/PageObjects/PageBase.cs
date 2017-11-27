using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace OC_Automation.PageObjects
{
   public abstract class PageBase
    {
        public BrowserWindow Browser { get; private set; }
        public PageBase()
        {
            Browser = new BrowserWindow();
        }

        protected void SetTextBoxValue(BrowserWindow browser, string elementId, string value)
        {
            var textBox = new HtmlEdit(browser);
            
            textBox.Text = value;


        }
    }
}
