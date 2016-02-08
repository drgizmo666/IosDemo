using System;

using UIKit;

namespace PickerAppDemo
{
	public partial class ViewController : UIViewController, IUIPickerViewDelegate, IUIPickerViewDataSource
	{
		public string[] CityNames = {"Bludhaven", "Central City", "Gorilla City", "Keystone City", "SmallVille", "Metropolis", "Star City", "Cosmos", "Gotham City", "RavenHolm"};
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public nint GetComponentCount (UIPickerView pickerView)
		{
			return 1;
		}

		public nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return CityNames.Length;

		}
	}
}

