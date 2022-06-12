using System;

using AppKit;
using Foundation;
using CharacterLibrary;

namespace CharacterGUI
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            var DataSource = new InventoryTableDataSource();
            grdInventory.DataSource = DataSource;
            grdInventory.Delegate = new InventoryTableDelegate(DataSource);
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void btnGenerateCharacter_Click(NSObject sender)
        {
            var newCharacter = new Character();
            newCharacter.GenerateCharacter();

            txtCharacterName.StringValue = newCharacter.CharacterName.ToString();
            txtStrength.StringValue = newCharacter.Strength.ToString();
            txtIntelligence.StringValue = newCharacter.Intelligence.ToString();
            txtWisdom.StringValue = newCharacter.Wisdom.ToString();
            txtDexterity.StringValue = newCharacter.Dexterity.ToString();
            txtConstitution.StringValue = newCharacter.Dexterity.ToString();
            txtCharisma.StringValue = newCharacter.Charisma.ToString();

            txtRecommendation.StringValue = newCharacter.RecommendClass();
        }
    }
}
