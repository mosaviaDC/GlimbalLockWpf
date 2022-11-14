using GlimbalLockWpf.Infastructure.Commands;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Text;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xaml;
using GlimbalLockWpf.Views;
using System.Windows.Media;
using GlimbalLockWpf.Models;
using System.Windows;

namespace GlimbalLockWpf.ViewModels
{
 public class InputControlViewModel:ViewModels.Base.ViewModelBase
    {

       public Grid LayoutGrid { get; set;}

        public List<System.Windows.Controls.Control> items { get; set; }


        public InputControlViewModel()
        {
            items = new List<Control>();
            items.Add(new TextBox()
            {
                Text = "Hello world",
                Width = 50,
                Height = 50,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            }) ;
        
          


        }
    }
}
