//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
using PokedexXF.Controls;
using PokedexXF.UWP.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomEntryBorderless), typeof(CustomEntryBorderlessRenderer))]
namespace PokedexXF.UWP.Renderers
{
    public class CustomEntryBorderlessRenderer : EntryRenderer
    {
        //public CustomEntryBorderlessRenderer(Context context) 
        //    : base() 
        //{ }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            
            if (e.NewElement != null)
            {
                //RnD
                //Control.SetBackground(null);
                Control.Background = null;
            }
            
        }
    }
}