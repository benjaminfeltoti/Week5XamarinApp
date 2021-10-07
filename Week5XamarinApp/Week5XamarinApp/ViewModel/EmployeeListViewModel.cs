using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Week5XamarinApp.Model;
using Xamarin.Forms;

namespace Week5XamarinApp.ViewModel
{
    class EmployeeListViewModel
    {
        public ICommand AddEmployeeCommand => new Command(AddEmployee);

        public ICommand RemoveEmployeeCommand => new Command(RemoveEmployee);

        public ICommand UpdateEmployeeCommand => new Command(UpdateEmployee);

        public ObservableCollection<Employee> Employees { get; set; }

        public string EmployeeName { get; set; }

        public string SelectedEmployee { get; set; }

        public EmployeeListViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee(1, "Rob Finnerty", "CEO", "img1.jpg"));
            Employees.Add(new Employee(2, "Bill Wrestler", "Director", "img2.jpg"));
            Employees.Add(new Employee(3, "Geri Beth Hooper", "Delivery Manager", "img3.jpg"));
            Employees.Add(new Employee(4, "Keith Joyce", "Project Manager", "img4.jpg"));
            Employees.Add(new Employee(5, "Sheri Spruce", "Software Engineer", "img5.jpg"));
            Employees.Add(new Employee(6, "Burt Indybrick", "Software Engineer", "img6.jpg"));

            MessagingCenter.Subscribe<AddOrEditEmployeePage, Employee>(this, "AddOrEditEmployee",
                (page, employee) =>
                {
                    if (employee.EmployeeId == 0)
                    {
                        employee.EmployeeId = Employees.Count + 1;
                    }
                    else
                    {
                        Employee employeeEdit = Employees.Where(emp => emp.EmployeeId == employee.EmployeeId).FirstOrDefault();

                        int newIndex = Employees.IndexOf(employeeEdit);
                        Employees.Remove(employeeEdit);

                        Employees.Add(employee);
                        int oldIndex = Employees.IndexOf(employee);

                        Employees.Move(oldIndex, newIndex);
                    }
                }
                );
        }

        public void AddEmployee()
        {
            Employees.Add(EmployeeName);
        }

        public void RemoveEmployee()
        {
            Employees.Remove(SelectedEmployee);
        }

        public void UpdateEmployee()
        {
            int newIndex = Employees.IndexOf(SelectedEmployee);
            Employees.Remove(SelectedEmployee);

            Employees.Add(EmployeeName);
            int oldIndex = Employees.IndexOf(EmployeeName);

            Employees.Move(oldIndex, newIndex);
        }
    }
}
