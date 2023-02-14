using A_Gadget_Store_App.Entities;
using A_Gadget_Store_App.Enum;
using A_Gadget_Store_App.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Gadget_Store_App.Repo
{
    public class Constants
    {
        public const string dir = @"C:\Users\ELIAS BASHIRUDEEN\OneDrive\Desktop\employeeRecord";
        public const string filename = "gadgets.txt";
        public static string fullpath = dir+"\\"+filename;

         public const string dire = @"C:\Users\ELIAS BASHIRUDEEN\OneDrive\Desktop\employeeRecord";
        public const string filename1 = "Wallet.Txt";
        public static string fullpath1 = dire+"\\"+filename1;

        public const string dirr = @"C:\Users\ELIAS BASHIRUDEEN\OneDrive\Desktop\employeeRecord";
        public const string filename2 = "Available gadgets.txt";
        public static string fullpath2 = dirr+"\\"+filename2;
    }
}