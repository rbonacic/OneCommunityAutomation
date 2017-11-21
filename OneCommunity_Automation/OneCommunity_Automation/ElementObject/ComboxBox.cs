using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace OneCommunity_Automation.ElementObject
{
    public class ComboxBox : ISelectable
    {
        private readonly HtmlComboBox _comboBox;

        public ComboxBox(BrowserWindow browserWindow)
        {
            _comboBox = new HtmlComboBox(browserWindow);

            _comboBox.TechnologyName = "Web";
            _comboBox.SearchProperties.Add("ControlType", "ComboBox");
        }

        // todo: create constants for search property keys 
        public ComboxBox(BrowserWindow browserWindow, string id)
        {
            _comboBox = new HtmlComboBox(browserWindow);
            _comboBox.SearchProperties.Add("Id", id);
        }

        public int Index
        {
            get { return _comboBox.SelectedIndex; }
            set { _comboBox.SelectedIndex = value; }
        }

        public string Value
        {
            get { return _comboBox.ValueAttribute; }
            set { _comboBox.SetProperty("Value", value); }
        }

        public void SetTagInstance(string tag)
        {
            _comboBox.SetProperty("TagInstance", tag);
        }
    }
}
