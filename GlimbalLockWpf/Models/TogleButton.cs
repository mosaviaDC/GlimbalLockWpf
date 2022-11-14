using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
namespace GlimbalLockWpf.Models
{
    internal class TogleButton
    {
        public Button Button { get; set; }

        public string ButtonName { get; set; }
        public TogleButton(string ButtonName)
        {
            Button =new Button();
            Button.MouseDown += Button_MouseDown;
            Button.Width = 50;
            Button.Height = 50;
          
            this.ButtonName = ButtonName;
        }

        private void Button_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           Debug.WriteLine($"Нажата кнопка {ButtonName}");
        }
    }
}
