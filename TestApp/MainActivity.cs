using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.TextField;
using TestApp.Adapters;
using TestApp.Models;
using AlertDialog = AndroidX.AppCompat.App.AlertDialog;

namespace TestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private AutoCompleteTextView autoCompleteTextView;
        private ClipboardManager clipboard;
        private AlertDialog progressDialog;
        private Button NextBtn;
        private RelativeLayout ProgressView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            autoCompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextView);
            NextBtn = FindViewById<Button>(Resource.Id.nxt_btn);
            ProgressView = FindViewById<RelativeLayout>(Resource.Id.progress_view);
            clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            NextBtn.Click += NextBtn_Click;

            //var suggestions = new List<string>
            //{
            //    "Apple", "Banana", "Cherry", "Date", "Grape", "Lemon", "Mango", "Orange", "Muha", "Muhamuha", "Musa", "Musendiku"
            //};
            //var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleDropDownItem1Line, suggestions);
            //autoCompleteTextView.Adapter = adapter;
            DrawableClickEvent();
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

            autoCompleteTextView.TextChanged += (sender, e) =>
            {
                //var filteredSuggestions = user.Where(s => s.AccountName.ToLower().Contains(autoCompleteTextView.Text.ToLower())).ToList();
                //adapter.Clear();
                //adapter.AddAll(filteredSuggestions);
                //adapter.NotifyDataSetChanged();
                if (!string.IsNullOrWhiteSpace(autoCompleteTextView.Text) && autoCompleteTextView.Text.Length == 10)
                {
                    ShowDottedProgress();
                }
            };

        }

        private async void ShowDottedProgress()
        {
            ProgressView.Visibility = ViewStates.Visible;

            // Simulate fetching data (replace with actual API call)
            await Task.Delay(5000); // Simulate a delay (e.g., network call)

            // Hide ProgressBar after data is fetched
            ProgressView.Visibility = ViewStates.Gone;
        }

        private void NextBtn_Click(object sender, System.EventArgs e)
        {
            //SmallProgressBar();
            //LoadDataAsync();
            ShowDottedProgress();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void DrawableClickEvent()
        {
            autoCompleteTextView.Touch += (s, e) =>
            {
                if (e.Event.Action == MotionEventActions.Up)
                {
                    // Get the drawable right bounds
                    if (autoCompleteTextView.GetCompoundDrawables()[2] != null) // DrawableRight is at index 2
                    {
                        // Get the width of the right drawable
                        var drawableRightWidth = autoCompleteTextView.GetCompoundDrawables()[2].Bounds.Width();

                        // Check if the touch event is within the bounds of the right drawable
                        if (e.Event.RawX >= (autoCompleteTextView.Right - drawableRightWidth))
                        {
                            // Handle the click event on DrawableRight
                            PasteTextFromClipboard(autoCompleteTextView, clipboard);
                            e.Handled = true; // Prevents further event propagation
                            return;
                        }
                    }
                }

                e.Handled = false; // Let the EditText handle other touch events
            };

        }
        private void HandleDrawableRightClick()
        {
            Toast.MakeText(this, "DrawableRight clicked", ToastLength.Long).Show();
        }

        private void PasteTextFromClipboard(AutoCompleteTextView editText, ClipboardManager clipboard)
        {
            if (clipboard.HasPrimaryClip && clipboard.PrimaryClip.Description.HasMimeType(ClipDescription.MimetypeTextPlain))
            {
                var item = clipboard.PrimaryClip.GetItemAt(0);
                var copiedText = item.Text;

                if (!string.IsNullOrEmpty(copiedText))
                {
                    // Paste the copied text into the TextInputEditText
                    editText.Text = copiedText;
                }
                else
                {
                    Toast.MakeText(this, "No text copied to clipboard", ToastLength.Short).Show();
                }
            }
            else
            {
                Toast.MakeText(this, "Clipboard is empty or contains non-text content", ToastLength.Short).Show();
            }
        }

        private void SmallProgressBar()
        {
            //AlertDialog progressDialog;
            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            // Inflate the custom layout
            LayoutInflater inflater = LayoutInflater.From(this);
            View view = inflater.Inflate(Resource.Layout.circular_progress_dialog, null);

            builder.SetView(view);
            builder.SetCancelable(false); // Prevent dismissing by clicking outside

            // Create and show the dialog
            progressDialog = builder.Create();
            progressDialog.Window.SetBackgroundDrawableResource(Android.Resource.Color.Transparent); // Make dialog background transparent
            progressDialog.Show();
        }

        private async void LoadDataAsync()
        {
            SmallProgressBar();
            // Show the progress dialog
            //progressDialog.Show();

            // Simulate a background operation (replace with your actual task)
            await Task.Delay(5000);

            // Hide the progress dialog when the task is done
            progressDialog.Dismiss();
        }
    }
}
