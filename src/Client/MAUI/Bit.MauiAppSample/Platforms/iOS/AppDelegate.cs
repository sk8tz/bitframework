﻿using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Bit.MauiAppSample
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
