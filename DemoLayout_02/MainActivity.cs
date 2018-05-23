using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V7.Widget;
using DemoLayout02.Helper;
using DemoLayout02;
using System;
using System.Collections.Generic;

namespace DemoLayout_02
{
    [Activity(Label = "ScreenID", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private RecyclerView recycler;
        private RecyclerViewAdapter adapter;
        private RecyclerView.LayoutManager layoutManager;

        private List<Data> lstData = new List<Data>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            ActionBar.Hide();

            InitData();
            recycler = FindViewById<RecyclerView>(Resource.Id.recycler);
            recycler.HasFixedSize = true;
            layoutManager = new LinearLayoutManager(this);
            recycler.SetLayoutManager(layoutManager);
            adapter = new RecyclerViewAdapter(lstData);
            recycler.SetAdapter(adapter);
        }

        private void InitData()
        {
            lstData.Add(new Data() { imageID = Resource.Drawable.pictireListInfor1pager1, title= "@string/linearLayout_Level2_tabPage1List1Content" });
            lstData.Add(new Data() { imageID = Resource.Drawable.pictireListInfor2pager1, title= "@string/linearLayout_Level2_tabPage1List2Content" });
            lstData.Add(new Data() { imageID = Resource.Drawable.pictireListInfor3pager1, title= "@string/linearLayout_Level2_tabPage1List3Content" });
            lstData.Add(new Data() { imageID = Resource.Drawable.pictireListInfor4pager1, title= "@string/linearLayout_Level2_tabPage1List4Content" });
        }
    }
}

