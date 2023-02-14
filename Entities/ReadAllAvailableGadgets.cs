using A_Gadget_Store_App.Entities;
using A_Gadget_Store_App.Enum;
using A_Gadget_Store_App.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Gadget_Store_App.Entities
{
    public class ReadAllAvailableGadgets
    {
        public static List<Gadgets> gadgets = new List<Gadgets>();
        static 
         Gadgets gadget = new Gadgets();
        public static void ReadFromTextFile()
        {
            try
            {
                ReadAllAvailableGadgets.WriteToFile();
                ReadAllAvailableGadgets.AppendToFile();
                 if (File.Exists(Constants.fullpath2))
                {
                    var lines = File.ReadAllLines(Constants.fullpath2);

                    foreach (var line in lines)
                    {
                        var item = (gadget.ToObj2(line));
                        Console.WriteLine($"We have here; {item}");
                        gadgets.Add(item);
                    }
                }
                else
                {
                    var dirr = Constants.dirr;
                    Directory.CreateDirectory(dirr);
                    var fileName2 = Constants.filename2;
                    var fullPath2 = Path.Combine(dirr, fileName2);
                    using (File.Create(fullPath2));
                }
            }
                
            catch (Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }
        }
        public static void WriteToFile()
        {
            TextWriter write = new StreamWriter(Constants.fullpath2);
            var gadgets = new Gadgets
            {
                ProductName = "Oraimo Giant Power Bank",
                Uniqueness = "40000mAh",
                Price = 60,
            };
            write.WriteLine(gadgets);
            write.Close();
            // write.WriteLine("2. Oraimo giant power bank 40000mAh($60)");
            // write.WriteLine("3. New age heavy power bank 20000mAh($30)");
            // write.Close();
        }
        public static void RefreshFile()
        {
            try
            {
                StreamWriter write = new StreamWriter(Constants.fullpath2);
                foreach (var item in gadgets)
                {
                    write.WriteLine(item.ToString());
                }write.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AppendToFile()
        {
            try
            {
                StreamWriter write = new StreamWriter(Constants.fullpath2,true);
                var gadgets = new Gadgets
                {
                    ProductName = "New age heavy power bank",
                    Uniqueness = "20000mAh",
                    Price = 40,
                };
                write.WriteLine(gadgets);
                write.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}