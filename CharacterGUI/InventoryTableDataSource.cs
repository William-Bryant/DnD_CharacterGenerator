using System;
using AppKit;
using CharacterLibrary;
using System.Collections.Generic;


namespace CharacterGUI
{
    public class InventoryTableDataSource : NSTableViewDataSource
    {
        public List<InventoryItem> Inventory { get; set; }
        public InventoryTableDataSource()
        {
            Inventory = new List<InventoryItem>();
            var cloak = new InventoryItem("Cloak", 4, 2);
            var staff = new InventoryItem("Staff", 3, 5);
            var torch = new InventoryItem("Torch", 1, 1);

            Inventory.Add(cloak);
            Inventory.Add(staff);
            Inventory.Add(torch);
        }

        public override nint GetRowCount(NSTableView tableview)
        {
            return Inventory.Count;
        }
    }
}
