using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace SectionIndexDemo
{
	partial class TableViewControler : UITableViewController
	{
		static NSString MyCellId = new NSString ("MyCellId");
		string[] tableItems;
		string[] keys;
		Dictionary<string, List<string>> indexedTableItems;

		public TableViewControler (IntPtr handle) : base (handle)
		{
			tableItems = new string[] 
			{ "Batman", "Superman", "Wonder Woman", "Flash", "Cyborg", "Aquaman", "Green Lantern", "Matian Manhunter", "Atom", "Element Woman", "Firestorm", "Shazam", "Lex Luthor", "Captian Cold", "Power Ring"};
			TableView.RegisterClassForCellReuse (typeof(MyCell), MyCellId);
			//create a dictionary of table sections
			//key = section name, value = list os strings
			indexedTableItems = new Dictionary<string, List<string>>();
			foreach (var t in tableItems) {
				if (indexedTableItems.ContainsKey (t [0].ToString ())) {
					indexedTableItems [t [0].ToString ()].Add (t);
				} else {
					indexedTableItems.Add (t [0].ToString (), new List<string> (){ t });
				}
			}

			keys = indexedTableItems.Keys.ToArray ();

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return keys.Length;		
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			//return tableItems.Length;
			return indexedTableItems[keys[section]].Count;
		}

		public override string[] SectionIndexTitles (UITableView tableView)
		{
			return keys;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			string item = tableItems [indexPath.Row];
			var cell = (MyCell)tableView.DequeueReusableCell (MyCellId, indexPath);
			cell.TextLabel.Text = item;

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			UIAlertController okAlertController = UIAlertController.Create ("You Have Picked ", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
			okAlertController.AddAction (UIAlertAction.Create ("Well Duh", UIAlertActionStyle.Default, null));
			this.PresentViewController (okAlertController, true, null);
			tableView.DeselectRow (indexPath, true);
		}
	}
}
