using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    public class EmployeeDataAccess
    {
        private readonly string connectionString;

        public EmployeeDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = Convert.ToInt32(reader["Id"]);
                            employee.Name = reader["Name"].ToString();
                            employee.Position = reader["Position"].ToString();
                            employee.Rating = Convert.ToDouble(reader["Rating"]);
                            employee.Email = reader["Email"].ToString();
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Employees (Name, Position, Rating, Email) VALUES (@Name, @Position, @Rating, @Email)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Position", employee.Position);
                command.Parameters.AddWithValue("@Rating", employee.Rating);
                command.Parameters.AddWithValue("@Email", employee.Email);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Employees SET Name = @Name, Position = @Position, Rating = @Rating, Email = @Email WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Position", employee.Position);
                command.Parameters.AddWithValue("@Rating", employee.Rating);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@Id", employee.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Employees WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public Employee GetEmployeeById(int id)
        {
            Employee employee = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees WHERE Id = @Id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Position = reader["Position"].ToString(),
                                Rating = Convert.ToDouble(reader["Rating"]),
                                Email = reader["Email"].ToString()
                            };
                        }
                    }
                }
            }
            return employee;
        }

        public List<Employee> GetHighestRatedEmployees(int count)
        {
            List<Employee> employees = new List<Employee>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees ORDER BY Rating DESC LIMIT @Count";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Count", count);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = Convert.ToInt32(reader["Id"]);
                            employee.Name = reader["Name"].ToString();
                            employee.Position = reader["Position"].ToString();
                            employee.Rating = Convert.ToDouble(reader["Rating"]);
                            employee.Email = reader["Email"].ToString();
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }
    }
}
