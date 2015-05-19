using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace DrawerLayoutUI
{
	public class RecyclerViewAdapter : RecyclerView.Adapter
	{
		string [] items;

		public RecyclerViewAdapter (string [] data)
		{
			items = data;
		}

		// Create new views (invoked by the layout manager)
		public override RecyclerView.ViewHolder OnCreateViewHolder (ViewGroup parent, int viewType)
		{	
			// set the view's size, margins, paddings and layout parameters
			var tv = new TextView (parent.Context);
			tv.SetWidth (200);
			tv.Text = "";

			var vh = new RecyclerViewHolder (tv);
			return vh;
		} 

		// Replace the contents of a view (invoked by the layout manager)
		public override void OnBindViewHolder (RecyclerView.ViewHolder viewHolder, int position)
		{
			var item = items [position];

			// Replace the contents of the view with that element
			var holder = viewHolder as RecyclerViewHolder;
			holder.TextView.Text = items[position];
		}

		public override int ItemCount {
			get {
				return items.Length;
			}
		}
	}

	public class RecyclerViewHolder : RecyclerView.ViewHolder 
	{
		public TextView TextView { get; set; }

		public RecyclerViewHolder (TextView v) : base (v)
		{
			TextView = v;
		}
	}
}

