#pragma checksum "C:\Users\fil19\Downloads\PaintBlaszkiewicz\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "89424E8B115015E825E83619B95632E4B822FA838595703594A39AB3CC58A8BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaintBlaszkiewicz
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.btnKolor = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3: // MainPage.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element3 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element3).PointerPressed += this.StackPanel_PointerPressed;
                }
                break;
            case 4: // MainPage.xaml line 30
                {
                    this.poleRysowania = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.poleRysowania).PointerPressed += this.poleRysowania_PointerPressed;
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.poleRysowania).PointerReleased += this.poleRysowania_PointerReleased;
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.poleRysowania).PointerMoved += this.poleRysowania_PointerMoved;
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.poleRysowania).SizeChanged += this.poleRysowania_SizeChanged;
                }
                break;
            case 5: // MainPage.xaml line 34
                {
                    this.rdbDowolna = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 6: // MainPage.xaml line 35
                {
                    this.rdbProsta = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 7: // MainPage.xaml line 36
                {
                    this.sliderGrubosc = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 8: // MainPage.xaml line 37
                {
                    this.textGruboscLinii = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // MainPage.xaml line 38
                {
                    this.btnKoniec = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnKoniec).Click += this.btnKoniec_Click;
                }
                break;
            case 10: // MainPage.xaml line 39
                {
                    this.btnClear = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnClear).Click += this.btnClear_Click;
                }
                break;
            case 11: // MainPage.xaml line 40
                {
                    this.btnUndo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnUndo).Click += this.btnUndo_Click;
                }
                break;
            case 12: // MainPage.xaml line 21
                {
                    this.rctBlack = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 13: // MainPage.xaml line 22
                {
                    this.rctRed = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 14: // MainPage.xaml line 23
                {
                    this.rctGreen = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 15: // MainPage.xaml line 24
                {
                    this.rctBlue = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 16: // MainPage.xaml line 25
                {
                    this.rctYellow = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 17: // MainPage.xaml line 26
                {
                    this.rctWhite = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 18: // MainPage.xaml line 15
                {
                    this.paleta = (global::Windows.UI.Xaml.Controls.ColorPicker)(target);
                    ((global::Windows.UI.Xaml.Controls.ColorPicker)this.paleta).PointerPressed += this.paleta_PointerPressed;
                    ((global::Windows.UI.Xaml.Controls.ColorPicker)this.paleta).PointerMoved += this.paleta_PointerMoved_1;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

