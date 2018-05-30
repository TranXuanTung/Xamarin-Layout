using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V7.Widget;
using Android.Support.V4.View;
using DemoLayout02.Helper;
using DemoLayout02;
using System;
using System.Collections.Generic;
using Android.Support.V4.App;

namespace DemoLayout_02
{
    [Activity(Label = "ScreenID", MainLauncher = true)]
    public class MainActivity : FragmentActivity
    {
        int count = 1;

        //private RecyclerView recycler;
        //private RecyclerViewAdapter adapter;
        //private RecyclerView.LayoutManager layoutManager;

        //private List<Data> lstData = new List<Data>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            ActionBar.Hide();

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            var pager = FindViewById<ViewPager>(Resource.Id.pager);
            var adapter = new viewPageFragmentAdapter(SupportFragmentManager);
            //viewPager tab 1 Layout level 2
            adapter.AddFragmentView((i,v,b) =>
            {
                var view = i.Inflate(Resource.Layout.titleLayoutLevel2, v, false);
                //var textSample = view.FindViewById<TextView>(Resource.Id.txtTitle);
                //textSample.Text = "";
                return view;
            });
            //viewPager tab 2 Layout level 2
            adapter.AddFragmentView((i, v, b) =>
            {
                var view = i.Inflate(Resource.Layout.titleLayoutLevel2, v, false);
                return view;
            });
            //viewPager tab 3 Layout level 2
            adapter.AddFragmentView((i, v, b) =>
            {
                var view = i.Inflate(Resource.Layout.titleLayoutLevel2, v, false);
                return view;
            });
            //viewPager tab 4 Layout level 2
            adapter.AddFragmentView((i, v, b) =>
            {
                var view = i.Inflate(Resource.Layout.titleLayoutLevel2, v, false);
                return view;
            });

            pager.Adapter = adapter;
            pager.SetOnPageChangeListener(new ViewPageListenerForActionBar(ActionBar));

            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "履歴"));
            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "フォロー"));
            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "フォロワー"));
            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "大会フォロー"));

            //InitData();
            //recycler = FindViewById<RecyclerView>(Resource.Id.recycler);
            //recycler.HasFixedSize = true;
            //layoutManager = new LinearLayoutManager(this);
            //recycler.SetLayoutManager(layoutManager);
            //adapter = new RecyclerViewAdapter(lstData);
            //recycler.SetAdapter(adapter);
        }

        //private void InitData()
        //{
        //    lstData.Add(new Data() { imageID = Resource.Drawable.pictireListInfor1pager1, title= "@string/linearLayout_Level2_tabPage1List1Content" });
        //    lstData.Add(new Data() { imageID = Resource.Drawable.pictireListInfor2pager1, title= "@string/linearLayout_Level2_tabPage1List2Content" });
        //    lstData.Add(new Data() { imageID = Resource.Drawable.pictireListInfor3pager1, title= "@string/linearLayout_Level2_tabPage1List3Content" });
        //    lstData.Add(new Data() { imageID = Resource.Drawable.pictireListInfor4pager1, title= "@string/linearLayout_Level2_tabPage1List4Content" });
        //}
    }
}

