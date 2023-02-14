using A_Gadget_Store_App.Entities;
using A_Gadget_Store_App.Enum;
using A_Gadget_Store_App.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Gadget_Store_App.Entities
{
    public class InfoService : Iinterface
    {
        private readonly IRepositories employeeRepo = new Repositories();


        public Customer_Info Create()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Kindly make sure all info are input correctly....");
            Console.Write("Enter first name: ");
            string firstname = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastname = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Input your phone number: ");
            string phone = Console.ReadLine();

            Console.Write("Input your password (minimum of 8 characters, an uppercase letter and a number.): ");
            string password = Console.ReadLine();

            int gender;
            do
            {
                Console.Write("Gender: \nenter 1 for Male\nenter 2 for Female\nenter 3 for RatherNotSay\nEnter your option: ");
            } while (!(int.TryParse(Console.ReadLine(), out gender) && IsValid(gender, 1, 3)));
            Console.Clear();
                        
        
            var info = new Customer_Info
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Phone = phone,
                Password = password,
                Gender = (Gender)gender, 
            };
            employeeRepo.WriteToFile(info);
            return info;
            
        }
       
        public static bool IsValid(int num, int start, int end)
        {
            return num >= start && num <= end;
        }
        public Customer_Info Login (string code, string password)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //var employee = Repositories.infos;
            var employee = employeeRepo.GetByCode(code);

            if (employee != null && employee.Password == password)
            {
                return employee;
            }

            return null;
            
        }

        
        // public string Order()
        // {

        // }

    }
}