using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace EmployeeManagementSystem
{
    public partial class EmployeeList : ContentPage
    {
        private readonly EmployeeDataAccess _employeeDataAccess;

        public EmployeeList(EmployeeDataAccess employeeDataAccess)
        {
            InitializeComponent();
            _employeeDataAccess = employeeDataAccess;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>(_employeeDataAccess.GetAllEmployees());
            employeeListView.ItemsSource = employees;
        }
    }
}
