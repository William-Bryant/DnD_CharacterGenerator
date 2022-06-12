using System;
namespace CharacterLibrary
{
    public class InventoryItem
    {
        public InventoryItem(string itemName, uint weight, uint cost)
        {
            ItemName = itemName;
            Weight = weight;
            Cost = cost;

        }



        public string ItemName { get; set; }

        public uint Weight { get; set; }

        public uint Cost { get; set; }
    }
}
