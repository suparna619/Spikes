﻿#pragma checksum "D:\visualStudio\SilverlightApplication\SilverlightApplication\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A184028C18121D367ACC5B6399CDD891"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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


namespace SilverlightApplication {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        private System.Windows.Controls.TextBox NameBox;
        
        internal System.Windows.Controls.TextBox AgeBox;
        
        internal System.Windows.Controls.TextBox Address1Box;
        
        internal System.Windows.Controls.TextBox Address2Box;
        
        internal System.Windows.Controls.TextBox Address3Box;
        
        internal System.Windows.Controls.Button SaveButton;
        
        internal System.Windows.Controls.HyperlinkButton btn;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverlightApplication;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.NameBox = ((System.Windows.Controls.TextBox)(this.FindName("NameBox")));
            this.AgeBox = ((System.Windows.Controls.TextBox)(this.FindName("AgeBox")));
            this.Address1Box = ((System.Windows.Controls.TextBox)(this.FindName("Address1Box")));
            this.Address2Box = ((System.Windows.Controls.TextBox)(this.FindName("Address2Box")));
            this.Address3Box = ((System.Windows.Controls.TextBox)(this.FindName("Address3Box")));
            this.SaveButton = ((System.Windows.Controls.Button)(this.FindName("SaveButton")));
            this.btn = ((System.Windows.Controls.HyperlinkButton)(this.FindName("btn")));
        }
    }
}

