using A_Gadget_Store_App.Entities;
using A_Gadget_Store_App.Enum;
using A_Gadget_Store_App.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Gadget_Store_App.Entities
{
    public class Wallet
    {
        public int Amount { get; set;}
        public static List<Wallet> wallet = new List<Wallet>();

        public override string ToString()
        {
            return $"{this.Amount}\t{" "}";
        }

        public static Wallet ToObj(string str)
        {
            var type = (str.Split("\t"));
            var obj = new Wallet
            {
                Amount = int.Parse(type[0]),
            };
            //Wallet.wallet.Add(obj);
            return obj;
        }

        public void Fund ()
        {
            
            try
            {
                Console.WriteLine("Enter amount to fund: ");
                int amount = int.Parse(Console.ReadLine());
                var wallet = new Wallet
                {
                    Amount = amount,
                };
                StreamWriter write = new StreamWriter(Constants.fullpath1);
                write.WriteLine(Amount.ToString());
                write.Close();
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadFromTextFile()
        {
            try
            {
                var obj = new Wallet();
                obj.Fund();
                if (File.Exists(Constants.fullpath1))
                {
                    var lines = File.ReadLines(Constants.fullpath1);

                    foreach (var line in lines)
                    {
                        var add = Wallet.ToObj(line);
                        wallet.Add(add);
                    }
                }
                else
                {
                    var dir = Constants.dire;
                    Directory.CreateDirectory(dir);
                    var fileName = Constants.filename1;
                    var fullPath = Path.Combine(dir, fileName);
                    using (File.Create(fullPath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void RefreshFile()
        {
            try
            {
                StreamWriter write = new StreamWriter(Constants.fullpath2);
                foreach (var item in wallet)
                {
                    write.WriteLine(item.ToString());
                }write.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}