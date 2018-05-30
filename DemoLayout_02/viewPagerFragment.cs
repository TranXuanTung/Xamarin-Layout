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

namespace DemoLayout02.Helper
{
    public class viewPagerFragment:Android.Support.V4.App.Fragment
    {
        private Func<LayoutInflater, ViewGroup, Bundle, View> _view;
        public viewPagerFragment(Func<LayoutInflater, ViewGroup, Bundle, View> view)
        {
            _view = view;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return base.OnCreateView(inflater, container, savedInstanceState);
            return _view(inflater, container, savedInstanceState);
        }
    }
}