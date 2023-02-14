using A_Gadget_Store_App.Entities;
using A_Gadget_Store_App.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Gadget_Store_App.Entities
{
    public class Customer_Info
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Amount {get; set; }
        public decimal Wallet{get; set; }
        public DateTime DateJoined { get; set; }

        public string GetByCode()
        {
            return this.Code;
        }

        public override string ToString()
        {
            return $"User Id: {this.Id}\tFullname: {this.LastName}\t{this.FirstName}\tCode: {this.Code}\tAnd Email: {this.Email}.";
        }
        public static Customer_Info ToObj(string str)
        {
            var type = str.Split("\t");
            var obj = new Customer_Info
            {
                Id = int.Parse(type[0]),
                LastName= type[1],
                FirstName= type[2],
                Code = type[3],
                Email = type[4],
            };
            return obj;
            
        }

    }
}