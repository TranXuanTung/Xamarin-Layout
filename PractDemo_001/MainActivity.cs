using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace PractDemo_001
{
    [Activity(Label = "Sign Up", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ActionBar.Hide();
            Button submit = FindViewById<Button>(Resource.Id.Button_submit);

            //var toolbar = FindViewById<Toolbar>(Resource.Id.icl_toolbar);
            //SetActionBar(toolbar);
            //ActionBar.Title = "Sign Up";

            submit.Click += (o, e) =>
            {
                var nameScreen = FindViewById<EditText>(Resource.Id.txtpln_screenName);
                var userID = FindViewById<EditText>(Resource.Id.txtpln_userID);
                var noFi01 = FindViewById<TextView>(Resource.Id.TextView_nofi01);
                var noFi02 = FindViewById<TextView>(Resource.Id.TextView_nofi02);
                var noFi03 = FindViewById<TextView>(Resource.Id.TextView_nofi03);
                var noFi04 = FindViewById<TextView>(Resource.Id.TextView_nofi04);

                if (nameScreen.Text.Length == 0 && userID.Text.Length > 0)
                {
                    noFi03.Visibility = ViewStates.Invisible;
                    noFi04.Visibility = ViewStates.Invisible;

                    noFi01.Visibility = ViewStates.Visible;
                    noFi02.Visibility = ViewStates.Visible;
                }
                if (userID.Text.Length == 0 && nameScreen.Text.Length > 0)
                {
                    noFi01.Visibility = ViewStates.Invisible;
                    noFi02.Visibility = ViewStates.Invisible;

                    noFi03.Visibility = ViewStates.Visible;
                    noFi04.Visibility = ViewStates.Visible;
                }
                if (nameScreen.Text.Length == 0 && userID.Text.Length == 0)
                {
                    noFi01.Visibility = ViewStates.Visible;
                    noFi02.Visibility = ViewStates.Visible;
                    noFi03.Visibility = ViewStates.Visible;
                    noFi04.Visibility = ViewStates.Visible;
                }
                if (nameScreen.Text.Length > 0 && userID.Text.Length > 0)
                {
                    noFi01.Visibility = ViewStates.Invisible;
                    noFi02.Visibility = ViewStates.Invisible;
                    noFi03.Visibility = ViewStates.Invisible;
                    noFi04.Visibility = ViewStates.Invisible;
                    nameScreen.Text = "";
                    userID.Text = "";
                    Toast.MakeText(this, "", ToastLength.Short).Show();
                }
            };
        }
    }
}

