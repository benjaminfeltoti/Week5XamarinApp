using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5XamarinApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week5XamarinApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeListPage : ContentPage
    {
        public EmployeeListPage()
        {
            InitializeComponent();
            BindingContext = new EmployeeListViewModel();
        }
    }
}