﻿#pragma checksum "C:\Users\Singgih Saputra\Documents\Visual Studio 2012\Projects\FIX with splashscreen edit\sm iso\sm\sm\KalenderPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B1FE0F919B96DC808FA79AA7EB671967"
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
    
    
    public partial class KalenderPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock AppointmentResultsLabel;
        
        internal System.Windows.Controls.ListBox AppointmentResultsData;
        
        internal Microsoft.Phone.Shell.ApplicationBar AppBar1;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton iconHapus;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/sm;component/KalenderPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.AppointmentResultsLabel = ((System.Windows.Controls.TextBlock)(this.FindName("AppointmentResultsLabel")));
            this.AppointmentResultsData = ((System.Windows.Controls.ListBox)(this.FindName("AppointmentResultsData")));
            this.AppBar1 = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("AppBar1")));
            this.iconHapus = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("iconHapus")));
        }
    }
}

