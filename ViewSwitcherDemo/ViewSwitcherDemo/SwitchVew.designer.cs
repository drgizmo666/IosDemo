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

namespace ViewSwitcherDemo
{
	[Register ("SwitchVew")]
	partial class SwitchVew
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView skullImg { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIToolbar SwitchToolbar { get; set; }

		[Action ("UIBarButtonItem17_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIBarButtonItem17_Activated (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (skullImg != null) {
				skullImg.Dispose ();
				skullImg = null;
			}
			if (SwitchToolbar != null) {
				SwitchToolbar.Dispose ();
				SwitchToolbar = null;
			}
		}
	}
}
