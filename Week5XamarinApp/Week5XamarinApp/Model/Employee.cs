using System;
using System.Collections.Generic;
using System.Text;
using Week5XamarinApp.ViewModel;

namespace Week5XamarinApp.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }

        public string PictureUrl { get; set; }

        public Employee()
        {
        }

        public Employee(int employeeId, string name, string designation, string pictureUrl)
        {
            EmployeeId = employeeId;
            Name = name;
            Designation = designation;
            PictureUrl = pictureUrl;
        }
    }
}
