using Microsoft.Maui.Controls;

namespace EmployeeManagementSystem
{
    public partial class HighestRatedEmployees : ContentPage
    {
        private readonly HighestRatedEmployeesViewModel _viewModel;

        public HighestRatedEmployees()
        {
            InitializeComponent();
            _viewModel = new HighestRatedEmployeesViewModel(new EmployeeDataAccess("Server=localhost;Database=EmployeeManagementSystem;Uid=root;Pwd=password;"));
            BindingContext = _viewModel;
        }

        private void ShowHighestRatedEmployees_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(countEntry.Text, out int count))
            {
                _viewModel.LoadHighestRatedEmployees(count);
            }
            else
            {
                DisplayAlert("Error", "Please enter a valid number.", "OK");
            }
        }
    }
}
