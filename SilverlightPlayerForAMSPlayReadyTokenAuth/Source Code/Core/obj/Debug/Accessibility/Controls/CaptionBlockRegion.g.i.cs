﻿#pragma checksum "C:\Users\christoc\Source\Silverlight Media Framework For Blogpost\microsoft-smf-src-2.2012.0605.0\Core\Accessibility\Controls\CaptionBlockRegion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E1745ECF1EADFC7178C326FC045CD44E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Microsoft.SilverlightMediaFramework.Core.Accessibility.Controls {
    
    
    public partial class CaptionBlockRegion : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Border CaptionsBorder;
        
        internal System.Windows.Controls.Grid CaptionsRoot;
        
        internal System.Windows.Controls.StackPanel captionsPanel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Microsoft.SilverlightMediaFramework.Core;component/Accessibility/Controls/Captio" +
                        "nBlockRegion.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CaptionsBorder = ((System.Windows.Controls.Border)(this.FindName("CaptionsBorder")));
            this.CaptionsRoot = ((System.Windows.Controls.Grid)(this.FindName("CaptionsRoot")));
            this.captionsPanel = ((System.Windows.Controls.StackPanel)(this.FindName("captionsPanel")));
        }
    }
}

