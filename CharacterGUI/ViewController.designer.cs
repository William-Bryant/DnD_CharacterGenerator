// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CharacterGUI
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTableColumn colCost { get; set; }

		[Outlet]
		AppKit.NSTableColumn colItem { get; set; }

		[Outlet]
		AppKit.NSTableColumn colWeight { get; set; }

		[Outlet]
		AppKit.NSTableView grdInventory { get; set; }

		[Outlet]
		AppKit.NSTextField txtCharacterName { get; set; }

		[Outlet]
		AppKit.NSTextField txtCharisma { get; set; }

		[Outlet]
		AppKit.NSTextField txtConstitution { get; set; }

		[Outlet]
		AppKit.NSTextField txtDexterity { get; set; }

		[Outlet]
		AppKit.NSTextField txtIntelligence { get; set; }

		[Outlet]
		AppKit.NSTextField txtRecommendation { get; set; }

		[Outlet]
		AppKit.NSTextField txtStrength { get; set; }

		[Outlet]
		AppKit.NSTextField txtWisdom { get; set; }

		[Action ("btnGenerateCharacter_Click:")]
		partial void btnGenerateCharacter_Click (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtCharacterName != null) {
				txtCharacterName.Dispose ();
				txtCharacterName = null;
			}

			if (txtCharisma != null) {
				txtCharisma.Dispose ();
				txtCharisma = null;
			}

			if (txtConstitution != null) {
				txtConstitution.Dispose ();
				txtConstitution = null;
			}

			if (txtDexterity != null) {
				txtDexterity.Dispose ();
				txtDexterity = null;
			}

			if (txtIntelligence != null) {
				txtIntelligence.Dispose ();
				txtIntelligence = null;
			}

			if (txtRecommendation != null) {
				txtRecommendation.Dispose ();
				txtRecommendation = null;
			}

			if (txtStrength != null) {
				txtStrength.Dispose ();
				txtStrength = null;
			}

			if (txtWisdom != null) {
				txtWisdom.Dispose ();
				txtWisdom = null;
			}

			if (grdInventory != null) {
				grdInventory.Dispose ();
				grdInventory = null;
			}

			if (colItem != null) {
				colItem.Dispose ();
				colItem = null;
			}

			if (colWeight != null) {
				colWeight.Dispose ();
				colWeight = null;
			}

			if (colCost != null) {
				colCost.Dispose ();
				colCost = null;
			}
		}
	}
}
