﻿#pragma checksum "C:\Users\Singgih Saputra\Documents\Visual Studio 2012\Projects\FIX with splashscreen edit\sm iso\sm\sm\NewReminderPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5C349F3133817269BFA1D9BB25BBA63B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace sm {
    
    
    public partial class NewReminderPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtTitle;
        
        internal System.Windows.Controls.TextBox txtContent;
        
        internal Microsoft.Phone.Controls.TimePicker timeX;
        
        internal Microsoft.Phone.Shell.ApplicationBar AppBar1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/sm;component/NewReminderPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtTitle = ((System.Windows.Controls.TextBox)(this.FindName("txtTitle")));
            this.txtContent = ((System.Windows.Controls.TextBox)(this.FindName("txtContent")));
            this.timeX = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("timeX")));
            this.AppBar1 = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("AppBar1")));
        }
    }
}
