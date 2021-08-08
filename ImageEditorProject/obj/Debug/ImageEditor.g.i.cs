﻿#pragma checksum "..\..\ImageEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18E36773EA5D4E55B3086AB175EBB20D87A4E531AE277B45A94D0756B721FCE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ImageEditorProject;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ImageEditorProject {
    
    
    /// <summary>
    /// ImageEditor
    /// </summary>
    public partial class ImageEditor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Colors;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label percentage;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider ZoomAmount;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ImageEditorProject.ZoomBorder border;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Component;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Back;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Drawing;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Brush;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ImageEditorProject;component/imageeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ImageEditor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Colors = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            
            #line 53 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Upload_Image);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 59 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Image);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 64 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_Pencil);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 69 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_Brush);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 74 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_Text);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 79 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_Pan);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 84 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_Highlight);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 90 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_Rectangle);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 96 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_RemoveEdits);
            
            #line default
            #line hidden
            return;
            case 11:
            this.percentage = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.ZoomAmount = ((System.Windows.Controls.Slider)(target));
            
            #line 114 "..\..\ImageEditor.xaml"
            this.ZoomAmount.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_move);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 116 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_Zoom);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 121 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_ZoomOut);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 126 "..\..\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_Reset);
            
            #line default
            #line hidden
            return;
            case 16:
            this.border = ((ImageEditorProject.ZoomBorder)(target));
            return;
            case 17:
            this.Component = ((System.Windows.Controls.Grid)(target));
            return;
            case 18:
            this.Back = ((System.Windows.Controls.Image)(target));
            return;
            case 19:
            this.Drawing = ((System.Windows.Controls.Canvas)(target));
            
            #line 138 "..\..\ImageEditor.xaml"
            this.Drawing.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CanvasMouseDown);
            
            #line default
            #line hidden
            
            #line 138 "..\..\ImageEditor.xaml"
            this.Drawing.MouseMove += new System.Windows.Input.MouseEventHandler(this.CanvasMouseMove);
            
            #line default
            #line hidden
            
            #line 138 "..\..\ImageEditor.xaml"
            this.Drawing.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseUp);
            
            #line default
            #line hidden
            return;
            case 20:
            this.Brush = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

