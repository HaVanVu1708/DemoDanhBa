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
using DemoDanhBa.Droid.CustomeRenderer;
using DemoDanhBa.Models.CutstomeRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Java.Security;

[assembly: ExportRenderer(typeof(MyCustomerEntry), typeof(MyEntryRenderer))]
namespace DemoDanhBa.Droid.CustomeRenderer
{
  public  class MyEntryRenderer  : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);

            }
        }

    }
}