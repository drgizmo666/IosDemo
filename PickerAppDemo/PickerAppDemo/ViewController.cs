using System;

using UIKit;

namespace PickerAppDemo
{
	public partial class ViewController : UIViewController, IUIPickerViewDataSource
	{
		public static string[] CityNames = {"Bludhaven", "Central City", "Gorilla City", "Keystone City", "SmallVille", 
			"Metropolis", "Star City", "Cosmos", "Gotham City", "RavenHolm"};
		
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			citysPicker.Delegate = new PickerViewDelegate ();
			citysPicker.DataSource = this;

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void UIButton45_TouchUpInside (UIButton sender)
		{
			nint row = citysPicker.SelectedRowInComponent(0);

			if(row == 9)
			{
				nameLabel.Text = "We don't go to RavenHolm";
			}
			else
			{
				nameLabel.Text = "Batman is on his way to " + CityNames[row];
			}

		}

		//Implementation IUIPickerViewDataSource
		public nint GetComponentCount (UIPickerView pickerView)
		{
			return 1;
		}

		public nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return CityNames.Length;

		}

		//Nested Class---derived from UIPickerViewDelegate
		class PickerViewDelegate : UIPickerViewDelegate
		{
			public override string GetTitle(UIPickerView pView, nint row, nint component)
			{
				return ViewController.CityNames[row];
			}
		}

	}
}

