using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeeManagementSystem
{
    public class HighestRatedEmployeesViewModel : INotifyPropertyChanged
    {
        private List<Employee> highestRatedEmployees;
        private readonly EmployeeDataAccess dataAccess;

        public List<Employee> HighestRatedEmployees
        {
            get { return highestRatedEmployees; }
            private set
            {
                if (highestRatedEmployees != value)
                {
                    highestRatedEmployees = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public HighestRatedEmployeesViewModel(EmployeeDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public void LoadHighestRatedEmployees(int count)
        {
            HighestRatedEmployees = dataAccess.GetHighestRatedEmployees(count);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

