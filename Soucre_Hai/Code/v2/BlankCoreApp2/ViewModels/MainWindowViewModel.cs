using BlankCoreApp2.Command;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace BlankCoreApp2.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        
        public ObservableCollection<string> myMessages { get; set; }
        public SimpleCommand MessageBoxCommand { get; private set; }
        public SimpleCommand ConsoleLogCommand { get; private set; }
        
       

        public MainWindowViewModel()
        {
            myMessages = new ObservableCollection<string>()
            {
                "My name is Hai",
                "Nguyen Van B",
                "Nguyen Van E",
                "I am message box",
                "I am console"
            };

            MessageBoxCommand = new SimpleCommand(DisplayInMessageBox, MessageCanUse);
            ConsoleLogCommand = new SimpleCommand(DisplayInConsole, ConsoleCanUse);
        }

        public void DisplayInMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }

        public void DisplayInConsole(object message)
        {
            Console.WriteLine((string)message);
        }


        public bool MessageCanUse(object message)
        {
            if ((string)message == "I am console")
            {
                return false;
            }
            return true;
        }

        public bool ConsoleCanUse(object message)
        {
            if ((string)message == "I am message box")
            {
                return false;
            }
            return true;
        }
    }
}
