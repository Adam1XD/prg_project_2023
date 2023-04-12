using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace prg_project_2023.Classes
{
    internal class SqlRepo
    {
        private string connectionString = "@";

        public void RegisterUser(string username, string password)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [Users] (Username,Password) values(@username,@password)";
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public User Login(string username, string password)
        {
            User user = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [User] WHERE Username=@username AND Password=@password";
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User((int)reader["Id"], reader["Username"].ToString(), reader["Password"].ToString());
                        }
                    }
                }
                sqlConnection.Close();
            }
            return user;
        }
        public List<Employee> GetEmployees(string search)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [Employee] WHERE Firstname LIKE @search";
                    cmd.Parameters.AddWithValue("search", "%" + search + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new Employee((int)reader["EmployeeId"], (string)reader
                                                            ["FirstName"], (string)reader["LastName"], DateTime.Parse(reader["BirthDate"].ToString()),
                                                            (string)reader["Email"], (string)reader["Phone"]);
                            employees.Add(employee);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return employees;
        }
        public List<User> GetUsers(string search)
        {
            List<User> users = new List<User>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [User] WHERE USERNAME LIKE @search";
                    cmd.Parameters.AddWithValue("search", "%" + search + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new User((int)reader["Id"], reader["Username"].ToString(), (string)reader["Role"]);
                            users.Add(user);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return users;
        }
        public void AddEmployee(string firstname, string lastname, string date, string email, string phone)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [Employee] (Firstname, Lastname, BirthDate, Email, Phone) values(@position,@firstname,@lastname,@date,@email,@phone)";
                    cmd.Parameters.AddWithValue("firstname", firstname);
                    cmd.Parameters.AddWithValue("lastname", lastname);
                    cmd.Parameters.AddWithValue("date", Convert.ToDateTime(date));
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("phone", phone);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void DeleteEmployee(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [Employee] WHERE EmployeeId=@employeeId";
                    cmd.Parameters.AddWithValue("employeeId", id);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public List<WorkType> GetWorkType(string search)
        {
            List<WorkType> worktypes = new List<WorkType>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [WorkType] WHERE NAME LIKE @search";
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var worktype = new WorkType((int)reader["Id"], reader["Name"].ToString(), reader["Description"].ToString());
                            worktypes.Add(worktype);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return worktypes;
        }
        public void AddWorkType(string name, string description)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [Employee] (Name, Descriptione) values(@name,@description)";
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("description", description);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void DeleteWorkType(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [WorkType] WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", id);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
    }
}
