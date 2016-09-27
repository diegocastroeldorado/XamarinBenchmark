using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Square.Picasso;

namespace PerformanceTest
{
    public class CustomListAdapter : BaseAdapter<string>
    {
        private Activity context;
        private String[] itemname;
        private String[] imgSource;

        public override int Count
        {
            get
            {
                return itemname.Length;
            }
        }

        public override string this[int position]
        {
            get
            {
                return itemname[position];
            }
        }

        public CustomListAdapter(Activity context, int textViewResourceId, String[] itemname, String[] imgSource) : base()  
        {
            this.context = context;
            this.itemname = itemname;
            this.imgSource = imgSource;           
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            LayoutInflater inflater = context.LayoutInflater;
            View rowView = inflater.Inflate(Resource.Layout.list, null, true);

            TextView txtTitle = (TextView)rowView.FindViewById(Resource.Id.Itemname);
            ImageView imageView = (ImageView)rowView.FindViewById(Resource.Id.ItemImage);            

            txtTitle.Text = itemname[position];            

            Picasso.With(context).Load(imgSource[position]).Into(imageView);

            return rowView;
        }

        public override long GetItemId(int position)
        {
            return position;
        }        
    }
}