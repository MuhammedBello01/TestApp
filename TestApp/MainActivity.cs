using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using TestApp.Adapters;
using TestApp.Models;

namespace TestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            AutoCompleteTextView autoCompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextView);
            //var suggestions = new List<string>
            //{
            //    "Apple", "Banana", "Cherry", "Date", "Grape", "Lemon", "Mango", "Orange", "Muha", "Muhamuha", "Musa", "Musendiku"
            //};
            //var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleDropDownItem1Line, suggestions);
            //autoCompleteTextView.Adapter = adapter;

            var user = new List<User>
            {
                new User { AccountName = "Baba", AccountNumber = "0137906395" },
                new User { AccountName = "Babamoh", AccountNumber = "0252898446" },
                new User { AccountName = "Cashhoo", AccountNumber = "5594449016" },
                new User { AccountName = "Carvana", AccountNumber = "0137906399" },
                new User { AccountName = "Alfa", AccountNumber = "0252898447" },
                new User { AccountName = "Meezoh", AccountNumber = "5594449078" }
            };
            var adapter = new ItemAdapter(this, user);
            autoCompleteTextView.Adapter = adapter;

            autoCompleteTextView.ItemClick += (sender, e) =>
            {
                var selectedItem = adapter.GetItem(e.Position);
                autoCompleteTextView.Text = selectedItem.AccountNumber;
                Toast.MakeText(this, "Selected: " + selectedItem.AccountNumber, ToastLength.Short).Show();
            };

            //autoCompleteTextView.TextChanged += (sender, e) =>
            //{
            //    var filteredSuggestions = user.Where(s => s.AccountName.ToLower().Contains(autoCompleteTextView.Text.ToLower())).ToList();

            //    adapter.Clear();
            //    adapter.AddAll(filteredSuggestions);
            //    adapter.NotifyDataSetChanged();
            //};

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
