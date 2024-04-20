using Microsoft.Maui.Controls;

namespace EmployeeManagementSystem
{
    public partial class MainPage : ContentPage
    {
        private readonly EmployeeDataAccess dataAccess;

        public MainPage(EmployeeDataAccess dataAccess)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
        }

        private void ViewAllEmployees_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EmployeeList(dataAccess));
        }

        private void AddEmployee_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddEmployee(dataAccess));
        }

        private void ViewHighestRatedEmployees_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HighestRatedEmployees());
        }
    }
}
