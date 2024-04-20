using Microsoft.Maui.Controls;
using System;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee : ContentPage
    {
        private readonly EmployeeDataAccess dataAccess;

        public AddEmployee(EmployeeDataAccess dataAccess)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
        }

        private void AddEmployee_Clicked(object sender, EventArgs e)
        {
            // Retrieve input values from the entries
            string name = nameEntry.Text;
            string position = positionEntry.Text;
            double rating = Convert.ToDouble(ratingEntry.Text); // Assuming rating is entered as a valid double
            string email = emailEntry.Text;

            // Create a new Employee object
            var newEmployee = new Employee()
            {
                Name = name,
                Position = position,
                Rating = rating,
                Email = email
            };

            // Add the new employee to the database
            dataAccess.AddEmployee(newEmployee);

            // Display a confirmation message
            DisplayAlert("Success", "Employee added successfully.", "OK");

            // Clear the entry fields
            ClearEntryFields();
        }

        private void ClearEntryFields()
        {
            nameEntry.Text = "";
            positionEntry.Text = "";
            ratingEntry.Text = "";
            emailEntry.Text = "";
        }
    }
}
