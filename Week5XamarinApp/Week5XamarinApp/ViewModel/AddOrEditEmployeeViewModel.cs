using System;
using System.Collections.Generic;
using System.Text;
using Week5XamarinApp.Model;

namespace Week5XamarinApp.ViewModel
{
    public class AddOrEditEmployeeViewModel : BaseViewModel
    {
        public Employee Employee { get; set; }

        public AddOrEditEmployeeViewModel()
        {
            Employee = new Employee();
        }
    }
}
