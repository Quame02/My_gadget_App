using A_Gadget_Store_App.Enum;
using A_Gadget_Store_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Gadget_Store_App
{
    public interface IRepositories
    {
        Customer_Info GetByIdOrCode(int id, string code);
        Customer_Info GetById(int id);
        Customer_Info GetByCode(string code);
        List<Customer_Info> GetAll();
        void WriteToFile(Customer_Info customer);
        //void RefreshFile();
        void ReadFromFile();
    }
}