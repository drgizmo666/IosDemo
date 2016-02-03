using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;

namespace ViewSwitcherDemo
{
	partial class SwitchVew : UIViewController
	{
		PinkViewController PVC;
		CopperViewController CVC;

		public SwitchVew (IntPtr handle) : base (handle)
		{
		}

		partial void UIBarButtonItem17_Activated (UIBarButtonItem sender)
		{
			//Create a View controller  object if necessary
			if(PVC == null)
				PVC = (PinkViewController)Storyboard.InstantiateViewController("Pink");
			if(CVC == null)
				CVC = (CopperViewController)Storyboard.InstantiateViewController("Copper");
			
			//if the copper view is displayed display pink view
			if(CVC.View.Superview != null)
			{
				//unload copper
				CVC.WillMoveToParentViewController(null);
				CVC.View.RemoveFromSuperview();
				CVC.RemoveFromParentViewController();
				//load pink View
				PVC.View.Frame = View.Frame;
				this.AddChildViewController(PVC);
				this.View.InsertSubview(PVC.View, atIndex:0);
				PVC.DidMoveToParentViewController(this);
				skullImg.Transform = CGAffineTransform.MakeRotation((float)Math.PI);
			}
			else
			{
				//unload pink
				PVC.WillMoveToParentViewController(null);
				PVC.View.RemoveFromSuperview();
				PVC.RemoveFromParentViewController();
				//load copper view
				skullImg.Transform = CGAffineTransform.MakeRotation(-(float)Math.PI);
				CVC.View.Frame = View.Frame;
				this.AddChildViewController(CVC);
				this.View.InsertSubview(CVC.View, atIndex:0);
				CVC.DidMoveToParentViewController(this);
			}


		}
	}
}
