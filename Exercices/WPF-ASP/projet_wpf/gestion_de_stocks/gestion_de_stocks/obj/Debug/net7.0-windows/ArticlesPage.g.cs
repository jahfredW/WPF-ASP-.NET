﻿#pragma checksum "..\..\..\ArticlesPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2BF2F5061C8FD771588EF6A8E859B61C5782E0AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using gestion_de_stocks;


namespace gestion_de_stocks {
    
    
    /// <summary>
    /// ArticlesPage
    /// </summary>
    public partial class ArticlesPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\ArticlesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_articles;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\ArticlesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_articles;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\ArticlesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_quantity;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\ArticlesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_category;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\ArticlesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_category;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\ArticlesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_valider;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\ArticlesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/gestion_de_stocks;component/articlespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ArticlesPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\ArticlesPage.xaml"
            ((gestion_de_stocks.ArticlesPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Article_Page_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\ArticlesPage.xaml"
            ((gestion_de_stocks.ArticlesPage)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dtg_articles = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\..\ArticlesPage.xaml"
            this.dtg_articles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmb_articles = ((System.Windows.Controls.ComboBox)(target));
            
            #line 58 "..\..\..\ArticlesPage.xaml"
            this.cmb_articles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmb_articles_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbx_quantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbx_category = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cmb_category = ((System.Windows.Controls.ComboBox)(target));
            
            #line 74 "..\..\..\ArticlesPage.xaml"
            this.cmb_category.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmb_articles_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_valider = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\ArticlesPage.xaml"
            this.btn_valider.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_delete = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\ArticlesPage.xaml"
            this.btn_delete.Click += new System.Windows.RoutedEventHandler(this.Delete_article);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 87 "..\..\..\ArticlesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_article);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

