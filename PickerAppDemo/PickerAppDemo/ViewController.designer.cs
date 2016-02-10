// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PickerAppDemo
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIPickerView citysPicker { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel nameLabel { get; set; }

		[Action ("UIButton45_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton45_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (citysPicker != null) {
				citysPicker.Dispose ();
				citysPicker = null;
			}
			if (nameLabel != null) {
				nameLabel.Dispose ();
				nameLabel = null;
			}
		}
	}
}
