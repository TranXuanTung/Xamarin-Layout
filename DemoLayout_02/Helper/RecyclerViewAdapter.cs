using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace DemoLayout02.Helper
{
    class RecyclerViewHolder :RecyclerView.ViewHolder
    {
        public ImageView imageView { get; set; }
        public TextView txtTitle { get; set; }

        public RecyclerViewHolder(View itemView):base(itemView)
        {
            imageView = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            txtTitle = itemView.FindViewById<TextView>(Resource.Id.txtTitle);
        }
    }
    class RecyclerViewAdapter : RecyclerView.Adapter
    {
        private List<Data> lstData = new List<Data>();

        public RecyclerViewAdapter(List<Data> lstData)
        {
            this.lstData = lstData;
        }

        public override int ItemCount
        {
            get
            {
                return lstData.Count;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            RecyclerViewHolder viewHolder = holder as RecyclerViewHolder;
            viewHolder.imageView.SetImageResource(lstData[position].imageID);
            viewHolder.txtTitle.Text = lstData[position].title;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View itemView = inflater.Inflate(Resource.Layout.title1, parent, false);
            return new RecyclerViewHolder(itemView);
        }
    }
}