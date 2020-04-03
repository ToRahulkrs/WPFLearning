using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tunneling_Bubbuling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseDown += OnMouseDown;
            MyBorder.MouseDown += OnMouseDown;
            BlueStackPanel.MouseDown += OnMouseDown;
            GreenRactangle.MouseDown += OnMouseDown;

            this.MouseEnter += OnMouseEnter;
            MyBorder.MouseEnter += OnMouseEnter;
            BlueStackPanel.MouseEnter += OnMouseEnter;
            GreenRactangle.MouseEnter += OnMouseEnter;

            //this.PreviewMouseDown += PreviewMouseDown;
            //MyBorder.PreviewMouseDown += PreviewMouseDown;
            //BlueStackPanel.PreviewMouseDown += PreviewMouseDown;
            //GreenRactangle.PreviewMouseDown += PreviewMouseDown;
        }

        private void OnMouseEnter(Object sender, MouseEventArgs e)
        {
            LogMouseDownEvent(sender, "MouseEnter");
        }

        private void OnMouseDown(Object sender, MouseButtonEventArgs mouseButtonEventArgs)
        {
            LogMouseDownEvent(sender, "MouseDown");
        }

        private void PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            LogMouseDownEvent(sender, "PreviewMouseDown");
        }
        
        private void LogMouseDownEvent(object sender, string eventName)
        {
            Debug.WriteLine("{0} fired on : {1}", eventName, sender);
        }
    }
}
