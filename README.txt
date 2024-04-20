Employee.cs: Defines the Employee class, which creates properties like Id, Name, Position, Rating, and Email.
EmployeeDataAccess.cs: Contains the EmployeeDataAccess class, Which works with the database. Includes methods to retrieve, add, update, and delete employee records from the database.
AddEmployee.xaml and AddEmployee.xaml.cs: The UI and code for the addEmployee part of the code respectively. The XAML and code files work to add an employee to the database when the user clicks the "Add Employee" button after writing the information.
EmployeeDetail.xaml and EmployeeDetail.xaml.cs:The UI layout and logic for viewing and editing employee details. The XAML file shows employee details in input fields, and the code file makes it so users can save changes made to employee details.
EmployeeDetailViewModel.cs: The view model class for the employee detail. It holds the selected employee object and works with the EmployeeDataAccess class to save changes made to employee details.
EmployeeList.xaml and EmployeeList.xaml.cs: The UI layout and code for displaying a list of employees. The XAML has a ListView for displaying employee records, and the code file gets the list of employees from the database and binds them to the ListView.
HighestRatedEmployees.xaml and HighestRatedEmployees.xaml.cs: The UI layout and code for displaying the highest-rated employees. The XAML contains input fields for specifying the number of highest-rated employees to display, and the code file gets and shows the highest-rated employees based on user input.
HighestRatedEmployeesViewModel.cs: This is the view model class for the highest-rated employees view. It interacts with the EmployeeDataAccess class to get and show the highest-rated employees.
MainPage.xaml and MainPage.xaml.cs: These files are the main UI layout and code for the main page. The XAML contains buttons for navigating to different views, and the code file handles the navigation logic.
MauiProgram.cs: This file contains the entry point for the Maui app.


The problem this program solves is that it helps executives at a workspace keep an eye on a worker's progress and proficiency by adding a rating system and also makes it easy to see the top performers using the HighestRatedEmployee files.