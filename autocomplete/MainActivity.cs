using Android;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace autocomplete
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        AutoCompleteTextView autoComplete;
        Button btn_Submit;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            autoComplete = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextView);
            btn_Submit = FindViewById<Button>(Resource.Id.button);
             
            var names = new string[] {"Afghanistan","Argentina","Australia","Austrian Empire","Bangladesh","Brazil","Canada","China","Colombia","Cuba","Finland","Egypt","Hawaii","Greece","Germany","Iceland","India","Indonesia","Nepal","Italy","Japan","Korea","Mexico",
                "Netherlands","Madagascar","Sri Lanka","Nigeria","Pakistan","Russia","Switzerland","Tajikistan","New Zealand","United Arab Emirates","Sweden","Turkey","United Kingdom","Thailand","Texas","Syria","Vietnam" };
            ArrayAdapter adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, names);
            autoComplete.Adapter = adapter;

            btn_Submit.Click += Btn_Submit_Click;


        }

        private void Btn_Submit_Click(object Sender, System.EventArgs e)
        {
            if (autoComplete.Text != "")
            {
                Toast.MakeText(this, "Country Name Entered = " + autoComplete.Text, ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "Please Enter the Country Name!", ToastLength.Short).Show();
            }
        }
    }


}



