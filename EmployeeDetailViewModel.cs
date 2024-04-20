namespace EmployeeManagementSystem
{
    public class EmployeeDetailViewModel
    {
        private readonly EmployeeDataAccess dataAccess;

        public Employee SelectedEmployee { get; }

        public EmployeeDetailViewModel(Employee employee, EmployeeDataAccess dataAccess)
        {
            SelectedEmployee = employee;
            this.dataAccess = dataAccess;
        }

        public void SaveChanges()
        {
            dataAccess.UpdateEmployee(SelectedEmployee);
        }
    }
}


