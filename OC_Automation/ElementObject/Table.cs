using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace OC_Automation.ElementObject
{
    public class Table
    {
        private readonly HtmlTable _htmlTable;

        public Table(BrowserWindow browserWindow, string cssClass)
        {
            UITestControl pageDocument = browserWindow.CurrentDocumentWindow;
            HtmlControl control = new HtmlControl(pageDocument);
            control.SearchProperties.Add(HtmlControl.PropertyNames.Class, cssClass);
            UITestControlCollection controlCollection = control.FindMatchingControls();

            _htmlTable = (HtmlTable)controlCollection.FirstOrDefault();
        }

        public HtmlTable GetTable
        {
            get { return _htmlTable; }
        }

        public List<HtmlCell> GetCellArrayAtRowIndex(int index)
        {
            if (_htmlTable == null)
            {
                throw new Exception("AccountsTable not initialized.");
            }

            return UiTableToArrayList(index);
        }

        public TUiTestControl GetControlAtRowColumn<TUiTestControl>(int row, int column)
            where TUiTestControl : UITestControl
        {
            var rowCellCollection = GetCellArrayAtRowIndex(row);

            return rowCellCollection[column]
                .GetChildren()
                .OfType<TUiTestControl>()
                .FirstOrDefault();
        }

        public List<HtmlCell> UiTableToArrayList(int rowIndex)
        {
            var cellList = new List<HtmlCell>();
                var rowcontrol = _htmlTable.GetRow(rowIndex);

                if (rowcontrol is HtmlRow)
                {
                    foreach (var cell in rowcontrol.GetChildren())
                    {
                        cellList.Add((HtmlCell)cell);
                    }
                }

            return cellList;
        }
    }
}
