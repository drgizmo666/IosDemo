using System;
using UIKit;
using Foundation;

namespace SectionIndexDemo
{
	public class CustomSuperCell : UITableViewCell
	{
		UILabel headingLabel, subheadingLabel;

		public CustomSuperCell (NSString cellId): base (UITableViewCellStyle.Default, cellId)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;
			ContentView.BackgroundColor = UIColor.FromRGB (117, 214, 92);
		}
	}
}

