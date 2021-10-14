using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5XamarinApp.Model;
using Week5XamarinApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week5XamarinApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddOrEditEmployeePage : ContentPage
    {
        public AddOrEditEmployeePage(Employee employee = null)
        {
            InitializeComponent();
            BindingContext = new AddOrEditEmployeeViewModel();
            if (employee != null)
                ((AddOrEditEmployeeViewModel)BindingContext).Employee = employee;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Employee employee = ((AddOrEditEmployeeViewModel)BindingContext).Employee;

            if (employee.EmployeeId == 0)
                employee.PictureUrl = "img7.jpg";

            MessagingCenter.Send(this, "AddOrEditEmployee", employee);
            Navigation.PopAsync();
        }
    }
}