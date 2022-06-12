using System;
using AppKit;
namespace CharacterGUI
{
    public class InventoryTableDelegate : NSTableViewDelegate
    {
        private const string CellIdentifier = "InventoryCell";
        private InventoryTableDataSource dataSource;

        public InventoryTableDelegate(InventoryTableDataSource ds)
        {
            dataSource = ds;
        }
        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            switch (tableColumn.Title)
            {
                case "Item":
                    view.StringValue = dataSource.Inventory[(int)row].ItemName;
                    break;

                case "Weight":
                    view.StringValue = dataSource.Inventory[(int)row].Weight.ToString();
                    view.Alignment = NSTextAlignment.Right;
                    break;

                case "Cost":
                    view.StringValue = dataSource.Inventory[(int)row].Cost.ToString();
                    view.Alignment = NSTextAlignment.Right;
                    break;
                
                
            }

            return view;
        }
    }
}
