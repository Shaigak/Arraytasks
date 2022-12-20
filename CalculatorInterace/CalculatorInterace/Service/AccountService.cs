using CalculatorInterace.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterace.Service
{
    internal class AccountService:IAccountService
    {
         
        public string name;
        public string password;

        public AccountService(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public void sign()
        {
            throw new NotImplementedException();
        }

        internal void Sign()
        {
            if (name == "Cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password yanlisdir");
            }
        }

        void IAccountService.AccountService()
        {
            
        }
    }
}
 
