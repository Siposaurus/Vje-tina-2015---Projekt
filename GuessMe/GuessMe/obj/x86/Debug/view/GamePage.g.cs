﻿#pragma checksum "C:\Users\Stella\Documents\Vje-tina-2015---Projekt\GuessMe\GuessMe\view\GamePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A0C872B9339DFC359F06550C9ABE2A49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuessMe
{
    partial class GamePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Game = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.CurrentTeam = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.SecondsTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.Next = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\view\GamePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Next).Click += this.OK_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\view\GamePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.Back_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

