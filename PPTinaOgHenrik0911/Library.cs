using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTinaOgHenrik0911
{
    internal class Library
    {
        public List<Employee> ListOfEmployees;
        public List <User> ListOfUsers;
        public List <Books> ListOfBooks;
        public Employee CurrentEmployee;
        public User CurrentUser;

        public Library()
        {
            ListOfEmployees = new List<Employee>();
            ListOfEmployees.Add(new Employee("Ola Nordmann", 1234, 1111, "Librarian"));
            ListOfEmployees.Add(new Employee("Kari Nordmann", 4321, 2222, "Librarian"));



            ListOfBooks = new List<Books>();
            ListOfBooks.Add(new Books(1001, "Mysteriekammeret", "J.K. Rowling", 306, true));
            ListOfBooks.Add(new Books(1002, "Den savnede søsteren", "Lucinda Riley", 768, true));



            ListOfUsers = new List<User>();
            ListOfUsers.Add(new User(100, "Håkon Johansen", "håkon.johansen@hotmail.com", 25));
            ListOfUsers.Add(new User(200, "Hans Jonny", "Hans.jonny@hotmail.com", 47));
            ShowStartMenu();
            var inputChoice = Console.ReadLine();
            Choice(inputChoice);
        }

        public void ShowStartMenu()
        {
            Console.WriteLine("Welcome to Library!");
            Console.WriteLine("1. Log in employee");
            Console.WriteLine("2. Show list of books");
            Console.WriteLine("3. Request books");
            Console.WriteLine("4. Return book");
        }

        public void EmployeeMenu()
        {
            Console.WriteLine("1. Register book on user");
            Console.WriteLine("2. Show list of books");
            Console.WriteLine("3. Return book");
            
        }

        public void Choice(string inputChoice)
        {
            if(inputChoice == "1")
            {
                FindEmployee();
                EmployeeMenu();
                var employeeChoice = Console.ReadLine();
                ChoiceOfEmployee(employeeChoice);
            }

            if(inputChoice == "2")
            {
                foreach (var books in ListOfBooks)
                {
                    books.ShowListOfBooks();
                }
            }
        }

        public void ChoiceOfEmployee(string employeeChoice)
        {
            if(employeeChoice == "1")
            {
                FindUser();
                //RegisterBookOnUser();
            }
        }

        public void FindEmployee()
        {
            Console.Write("Please enter your employee ID: ");
            int enteredId = Convert.ToInt32(Console.ReadLine());
            CurrentEmployee = ListOfEmployees.FirstOrDefault(employee => employee.EmployeeId == enteredId);
            if(CurrentEmployee != null)
            {
                CheckPwd();
            } else 
            { 
                
                Console.WriteLine("Invalid Id.");
                FindEmployee();
            }
        }

        public void CheckPwd()
        {
            Console.Write("Please enter your password: ");
            int enterPwd = Convert.ToInt32(Console.ReadLine());

            if(enterPwd == CurrentEmployee.EmployeePwd)
            {
                Console.WriteLine("You are currently logged in as: " + CurrentEmployee.Name);
            } else
            {
                Console.WriteLine("Wrong Password, Try again.");
                CheckPwd(); 
            }

        }

        public void FindUser()
        {
            Console.Write("Enter the user id: ");
            var enteredUserID = Convert.ToInt32(Console.ReadLine());
            CurrentUser = ListOfUsers.FirstOrDefault(user => user.UserId == enteredUserID);
            if( CurrentUser != null )
            {
                Console.WriteLine("Current user is: " + CurrentUser.Name);
            } else
            {
                Console.WriteLine("User not found, please try again.");
                FindUser();
            }
        }




    }

}
