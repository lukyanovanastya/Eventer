using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using XamForms.Controls;
using Xamarin.Forms;

namespace test.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            
            //SearchCommand 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        string searchText;
        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;
                var args = new PropertyChangedEventArgs(nameof(SearchText));
                PropertyChanged?.Invoke(this, args);
            }
        }

        Calendar calendar;

        public Command FilterCommand { get; }
        public Command SearchCommand { get; }
    }
}