using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountNumberPredictionLibrary2;
using Android.Animation;
using Android.App;
using Android.Content;
using Android.Gestures;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using Google.Android.Material.TextField;
using TestApp.Adapters;
using TestApp.Models;
using TestApp.Utils;
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
        private CustomDottedProgressBar progressBar;
        private List<User> user;
        private RecyclerView PredictionRv;
        private ListView listView;
        private ItemAdapter itemAdapter;
        private EditText editText;
        private ImageView myImageView;
        ObjectAnimator rotateAnimation;
        bool isAnimating = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            autoCompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextView);
            autoCompleteTextView.VerticalScrollBarEnabled = true; // Enable vertical scroll bar
            autoCompleteTextView.ScrollBarStyle = ScrollbarStyles.InsideInset;
            //autoCompleteTextView.DropDownHeight = 400;
            //autoCompleteTextView.DropDownWidth = ViewGroup.LayoutParams.MatchParent;

            NextBtn = FindViewById<Button>(Resource.Id.nxt_btn);
            ProgressView = FindViewById<RelativeLayout>(Resource.Id.progress_view);
            progressBar = FindViewById<CustomDottedProgressBar>(Resource.Id.progressBar);
            clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            NextBtn.Click += NextBtn_Click;
            MLInterpreterHelper.Instance.Initialize(this);

            PredictionRv = FindViewById<RecyclerView>(Resource.Id.prediction_rv);
            listView = FindViewById<ListView>(Resource.Id.listView);

            progressBar.Speed = 2; // Set speed of rotation
            progressBar.FrameRate = 5; // Set frame rate for smoother/faster updates. The lower the better
            progressBar.DotCount = 8; // More dots for denser circle
            progressBar.MinDotSize = 2f; // Minimum size of dots
            progressBar.MaxDotSize = 7f; // Maximum size of dots
            progressBar.Stop();
            editText = FindViewById<EditText>(Resource.Id.search_edit);
            editText.SetCompoundDrawablesWithIntrinsicBounds(Resource.Drawable.ic_search, 0, 0, 0);

            editText.TextChanged += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(editText.Text))
                {
                    editText.SetCompoundDrawablesWithIntrinsicBounds(0, 0, Resource.Drawable.abc_ic_clear_material, 0);
                }
                else
                {
                    editText.SetCompoundDrawablesWithIntrinsicBounds(Resource.Drawable.ic_search, 0, 0, 0);
                }
            };

            // Find the ImageView in the layout
            myImageView = FindViewById<ImageView>(Resource.Id.myImageView);
            rotateAnimation = ObjectAnimator.OfFloat(myImageView, "rotation", 0f, 360f);
            rotateAnimation.SetDuration(500); // 1 second for a full rotation
            rotateAnimation.RepeatCount = ValueAnimator.Infinite; // Infinite rotation
            rotateAnimation.RepeatMode = ValueAnimatorRepeatMode.Restart;

            // Set a click listener on the ImageView
            myImageView.Click += (sender, e) =>
            {
                if (!isAnimating)
                {
                    // Start the animation
                    rotateAnimation.Start();
                    isAnimating = true;
                }
                else
                {
                    // Stop the animation
                    rotateAnimation.Cancel();
                    isAnimating = false;
                }
            };

            //var suggestions = new List<string>
            //{
            //    "Apple", "Banana", "Cherry", "Date", "Grape", "Lemon", "Mango", "Orange", "Muha", "Muhamuha", "Musa", "Musendiku"
            //};
            //var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleDropDownItem1Line, suggestions);
            //autoCompleteTextView.Adapter = adapter;
            DrawableClickEvent();
            user = new List<User>
            {
                new User { AccountName = "Baba", AccountNumber = "0137906395" },
                new User { AccountName = "Babamoh", AccountNumber = "0252898446" },
                new User { AccountName = "Cashhoo", AccountNumber = "5594449016" },
                new User { AccountName = "Carvana", AccountNumber = "0137906399" },
                new User { AccountName = "Alfa", AccountNumber = "0252898447" },
                new User { AccountName = "Baba", AccountNumber = "0137906395" },
                new User { AccountName = "Babamoh", AccountNumber = "0252898446" },
                new User { AccountName = "Cashhoo", AccountNumber = "5594449016" },
                new User { AccountName = "Carvana", AccountNumber = "0137906399" },
                new User { AccountName = "Alfa", AccountNumber = "0252898447" },
                new User { AccountName = "Baba", AccountNumber = "0137906395" },
                new User { AccountName = "Babamoh", AccountNumber = "0252898446" },
                new User { AccountName = "Cashhoo", AccountNumber = "5594449016" },
                new User { AccountName = "Carvana", AccountNumber = "0137906399" },
                new User { AccountName = "Alfa", AccountNumber = "0252898447" },
                new User { AccountName = "Baba", AccountNumber = "0137906395" },
                new User { AccountName = "Babamoh", AccountNumber = "0252898446" },
                new User { AccountName = "Cashhoo", AccountNumber = "5594449016" },
                new User { AccountName = "Carvana", AccountNumber = "0137906399" },
                new User { AccountName = "Alfa", AccountNumber = "0252898447" },
                new User { AccountName = "Baba", AccountNumber = "0137906395" },
                new User { AccountName = "Babamoh", AccountNumber = "0252898446" },
                new User { AccountName = "Cashhoo", AccountNumber = "5594449016" },
                new User { AccountName = "Carvana", AccountNumber = "0137906399" },
                new User { AccountName = "Alfa", AccountNumber = "0252898447" },
                new User { AccountName = "Meezoh", AccountNumber = "5594449078" }
            };
            itemAdapter = new ItemAdapter(this, user);
            autoCompleteTextView.Adapter = itemAdapter;

            autoCompleteTextView.ItemClick += (sender, e) =>
            {
               
            };

            autoCompleteTextView.TextChanged += (sender, e) =>
            {
                //var filteredSuggestions = user.Where(s => s.AccountName.ToLower().Contains(autoCompleteTextView.Text.ToLower())).ToList();
                //var filteredSuggestions = suggestions.Where(s => s.ToLower().Contains(autoCompleteTextView.Text.ToLower())).ToList();
                //adapter.Clear();
                //adapter.AddAll(filteredSuggestions);
                //adapter.NotifyDataSetChanged();
                autoCompleteTextView.ShowDropDown();
                listView.Adapter = null;
                if (!string.IsNullOrWhiteSpace(autoCompleteTextView.Text) && autoCompleteTextView.Text.Length == 10)
                {
                    //if (autoCompleteTextView.Adapter != null)
                    //{
                    //    autoCompleteTextView.Adapter = null; 
                    //}
                    ShowDottedProgress();
                }
            };
            ProgressView.Visibility = ViewStates.Visible;
        }

        private async void ShowDottedProgress()
        {
            autoCompleteTextView.ClearFocus();
            //ProgressView.Visibility = ViewStates.Visible;
            progressBar.Start();

            // Simulate fetching data (replace with actual API call)
            await Task.Delay(5000); // Simulate a delay (e.g., network call)
           // progressBar.Stop();
            // Hide ProgressBar after data is fetched
            //ProgressView.Visibility = ViewStates.Gone;
            Console.WriteLine("delay done.............");
            try
            {
                TFLiteModel model = new TFLiteModel(MLInterpreterHelper.Instance.GetInterpreter());
                Console.WriteLine("Step 1.............");

                IDictionary<string, string> predictions = model.Predict(autoCompleteTextView.Text.ToString());
                Console.WriteLine($"Step 2.............{predictions}");

                predictions.Add("Cant Find Bank?", "");

                var displayList = predictions.Select(kvp => $"{kvp.Key}: {kvp.Value}").ToList();

                var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleDropDownItem1Line, displayList);
                listView.Adapter = adapter;
                listView.ItemClick += (sender, e) =>
                {
                    // Get the clicked item
                    string clickedItem = displayList[e.Position];
                    Toast.MakeText(this, $"You clicked: {clickedItem}", ToastLength.Short).Show();
                };

                //itemAdapter = new ItemAdapter(this, user);
                Console.WriteLine("Done.............");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception.............{ex}");
                var adapter = new ItemAdapter(this, user);
                autoCompleteTextView.Adapter = adapter;

            }

        }

        private void NextBtn_Click(object sender, System.EventArgs e)
        {

            if (!isAnimating)
            {
                progressBar.Start();
                isAnimating = true;
            }
            else
            {
                progressBar.Stop();
                isAnimating = false;
            }
           
           
            //rotateAnimation.Cancel();
            //isAnimating = false;
            //SmallProgressBar();
            //LoadDataAsync();
            //ShowDottedProgress();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void DrawableClickEvent()
        {
            if (editText != null)
            {
                editText.Touch += (s, e) =>
                {
                    if (e.Event.Action == MotionEventActions.Up)
                    {
                        if (editText.GetCompoundDrawables()[2] != null)
                        {
                            var drawableRightWidth = editText.GetCompoundDrawables()[2].Bounds.Width();
                            if (e.Event.RawX >= (editText.Right - drawableRightWidth))
                            {
                                editText.Text = string.Empty;
                                // PasteTextFromClipboard(autoCompleteTextView, clipboard);
                                e.Handled = true; // Prevents further event propagation
                                return;
                            }
                        }
                    }

                    e.Handled = false; // Let the EditText handle other touch events
                };
            }
            

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
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            LayoutInflater inflater = LayoutInflater.From(this);
            View view = inflater.Inflate(Resource.Layout.circular_progress_dialog, null);

            builder.SetView(view);
            builder.SetCancelable(false); 

            progressDialog = builder.Create();
            progressDialog.Window.SetBackgroundDrawableResource(Android.Resource.Color.Transparent); 
            progressDialog.Show();
        }

        private async void LoadDataAsync()
        {
            SmallProgressBar();
            await Task.Delay(5000);
            progressDialog.Dismiss();
        }
    }
}
