using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Test
{
    public class Writer
    {
        private static Window mw; 

        public void Write()
        {
        }

        public void gg()
        {
            mw = (MainWindow)App.Current.MainWindow;
            //MainWindow.TextBlockWrite("テスト");
            var mainWindow = (MainWindow)App.Current.MainWindow;
            var wm = Application.Current.MainWindow;
            mainWindow.TextBlockWrite(mainWindow+"テストtest200528"+wm+" --- "+mw);
           
        }
    }
}
