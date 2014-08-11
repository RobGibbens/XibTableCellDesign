using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XibTableCellDesign
{
	public partial class MyCustomCell : UITableViewCell
	{
		public Conference Model { get; set;}

		public static readonly UINib Nib = UINib.FromName ("MyCustomCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("MyCustomCell");

		public MyCustomCell (IntPtr handle) : base (handle)
		{
		}

		public static MyCustomCell Create ()
		{
			return (MyCustomCell)Nib.Instantiate (null, null) [0];
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			this.ConferenceName.Text = Model.Name;
			this.ConferenceStart.Text = Model.StartDate.ToShortDateString ();
			this.ConferenceDescription.Text = Model.Description;
		}
	}
}