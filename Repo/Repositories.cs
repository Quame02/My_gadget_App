using A_Gadget_Store_App.Enum;
using A_Gadget_Store_App.Entities;
using A_Gadget_Store_App.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Gadget_Store_App
{
    public class Repositories : IRepositories
    {
        public static List<Customer_Info> infos = new List<Customer_Info>();

        public Repositories()
        {
            //infos = new List<Info>();
            ReadFromFile();
        }
        public Customer_Info GetByIdOrCode(int id, string code)
        {
            return infos.Find(i => i.Code == code || i.Id == id);
        }
        public Customer_Info GetById(int id)
        {
            return infos.Find(i => i.Id == id);
        }
        public Customer_Info GetByCode(string code)
        {
            return infos.Find(i => i.Code == code);
        }
        public List<Customer_Info> GetAll()
        {
            return infos;
        }
        
        public void WriteToFile(Customer_Info customer)
        {
            try
            {
                using (StreamWriter write = new StreamWriter(Constants.fullpath, true))
                {
                    write.WriteLine(customer.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Account created successfully.....\nKindly proceed to your order");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RefreshFile()
        {
            try
            {
                using (StreamWriter write = new StreamWriter(Constants.fullpath))
                {
                    foreach (var a in infos)
                    {
                        write.WriteLine(a.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ReadFromFile()
        {
            try
            {
                if (File.Exists(Constants.fullpath))
                {
                    var lines = File.ReadAllLines(Constants.fullpath);

                    foreach (var line in lines)
                    {
                        var customer = Customer_Info.ToObj(line);
                        infos.Add(customer);
                    }
                }
                else
                {
                    var dir = Constants.dir;
                    Directory.CreateDirectory(dir);
                    var fileName = Constants.filename;
                    var fullPath = Path.Combine(dir, fileName);
                    using (File.Create(fullPath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
