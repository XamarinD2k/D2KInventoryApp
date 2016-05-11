using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Inventory
{
	public partial class LogIn : ContentPage
	{
		public LogIn ()
		{
			InitializeComponent ();

			var tgr = new TapGestureRecognizer ();
			forgetPasswordLabel.GestureRecognizers.Add (tgr);

			tgr.Tapped += (object sender, EventArgs e) => {
				DisplayAlert("","Click","OK");

			

			};
			///DimUser emp = GlobalFunctions.GetDataByIndex (GlobalVariables.CurrentIndex);

		
		}
//		public void OnSubmit(object sender,EventArgs e)
//		{
//			DimUser emp = new DimUser ();
//			emp.UserId = txtUserName.Text;
//			emp.Password = txtPassword.Text;
//		}
		protected override void OnAppearing ()
		{
			base.OnAppearing ();
		}
		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
		}
	}
}

