using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Week5XamarinApp.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
