using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;
using TestApp.Models;
using TestApp.Utils;

namespace TestApp.Adapters
{
	public class ItemAdapter : ArrayAdapter<User>, IFilterable
    {
        private Context _context;
        //private List<User> _items;
        private List<User> _originalItems;   // Store the original full list
        private List<User> _filteredItems;
        private Filter _filter;

        public ItemAdapter(Context context, List<User> items) : base(context, Resource.Layout.dropdown_item, items)
        {
            _context = context;
            //_items = items;
            _originalItems = new List<User>(items);  // Keep original list intact
            _filteredItems = new List<User>(items);  // Initialize filtered list

            // Set up filtering logic
            _filter = new UserFilter(this);
        }

        public override int Count => _filteredItems.Count;

        public User GetItem(int position)
        {
            return _filteredItems[position];
        }

        // Override GetView to customize the dropdown item view
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            // Reuse the view if possible, otherwise inflate the custom layout
            var view = convertView ?? LayoutInflater.From(_context).Inflate(Resource.Layout.dropdown_item, parent, false);

            // Get the current item
            var item = _filteredItems[position];

            // Find the TextView in the custom layout and set its value
            var textViewItem = view.FindViewById<TextView>(Resource.Id.textViewItem);
            var textViewItem_ii = view.FindViewById<TextView>(Resource.Id.textViewItem_ii);
            textViewItem.Text = item.AccountName;  // Display the 'Name' property or customize this
            textViewItem_ii.Text = item.AccountNumber;
            return view;
        }

        public override Filter Filter => _filter;

        private class UserFilter : Filter
        {

            private readonly ItemAdapter _adapter;

            public UserFilter(ItemAdapter adapter)
            {
                _adapter = adapter;
            }
            protected override FilterResults PerformFiltering(ICharSequence constraint)
            {

                var filterResults = new FilterResults();
                if (constraint == null || constraint.Length() == 0)
                {
                    // No filter applied (i.e., when the input is empty, return the original list)
                    filterResults.Values = FromArray(_adapter._originalItems.Select(r => r.ToJavaObject()).ToArray());
                    filterResults.Count = _adapter._originalItems.Count;
                }
                else
                {
                    // Apply filter logic here (filter the original list based on the input)
                    var searchTerm = constraint.ToString().ToLower();
                    //var filteredList = _adapter._originalItems
                    //    .Where(item => item.AccountName.ToLower().Contains(searchTerm))  // Filter based on the Name property
                    //    .ToList();

                    var filteredList = _adapter._originalItems
                        .Where(item => item.AccountName.ToLower().Contains(searchTerm) || item.AccountNumber.ToLower().Contains(searchTerm))
                        .ToList();

                    // Return the filtered results
                    // filterResults.Values = filteredList.ToArray();
                    filterResults.Values = FromArray(filteredList.Select(r => r.ToJavaObject()).ToArray());

                    filterResults.Count = filteredList.Count;
                }

                return filterResults;
            }

            protected override void PublishResults(ICharSequence constraint, FilterResults results)
            {
                // Update the adapter's filtered list and notify the changes
                //_adapter._filteredItems = results.Values.ToArray<User>().ToList();

                using (var values = results.Values)
                    _adapter._filteredItems = values.ToArray<Java.Lang.Object>()
                       .Select(r => r.ToNetObject<User>()).ToList();

                _adapter.NotifyDataSetChanged();
            }
        }
    }
}

