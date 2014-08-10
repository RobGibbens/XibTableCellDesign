using System.Collections.Generic;
using MonoTouch.UIKit;

namespace XibTableCellDesign
{
	public class MyTableViewController : UITableViewController
	{
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var conferences = ConferenceRepository.GetConferences ();

			TableView.Source = new MyTableViewSource (conferences);
		}

		public override void ViewDidLayoutSubviews ()
		{
			base.ViewDidLayoutSubviews ();

			if (UIDevice.CurrentDevice.CheckSystemVersion (7, 0)) {
				this.TableView.ContentInset = new UIEdgeInsets (this.TopLayoutGuide.Length, 0, 0, 0);
			}
		}
	}
}