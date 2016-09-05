using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Content.PM;
using Android.Views;
using Android.Widget;
using Android.OS;

using Microsoft.Xna.Framework;

namespace UnforeseenConsequences.Droid
{
    [Activity(Label = "UnforeseenConsequences.Droid",
              MainLauncher = true,
              Icon = "@drawable/icon",
              Theme = "@style/Theme.Splash",
              AlwaysRetainTaskState = true,
              LaunchMode = LaunchMode.SingleInstance,
              ConfigurationChanges = 
                                     ConfigChanges.KeyboardHidden |
                                     ConfigChanges.Keyboard)]
    public class MainActivity : AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create our OpenGL view, and display
            var g = new Game1();
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }

    }
}


