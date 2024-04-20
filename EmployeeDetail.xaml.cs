using Microsoft.Maui.Controls;

namespace EmployeeManagementSystem
{
    public partial class EmployeeDetail : ContentPage
    {
        private readonly EmployeeDetailViewModel viewModel;

        public EmployeeDetail(Employee employee, EmployeeDataAccess dataAccess)
        {
            InitializeComponent();
            viewModel = new EmployeeDetailViewModel(employee, dataAccess);
            BindingContext = viewModel;
        }

        private void SaveChanges_Clicked(object sender, EventArgs e)
        {
            viewModel.SaveChanges();
        }
    }
}
