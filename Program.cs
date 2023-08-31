using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Sharp_Class1
{
    class Shop
    {
        private string _name;
        private string _adress;
        private string _description;
        private string _phone;
        private string _email;

        public Shop(string name, string adress, string desc, string phone, string email)
        {
            this._name = name;
            this._adress = adress;
            this._description = desc;
            this._phone = phone;
            this._email = email;
        }

        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_adress);
            Console.WriteLine(_description);
            Console.WriteLine(_phone);
            Console.WriteLine(_email);
        }

        public string GetName() { return _name;}
        public string GetAdress() { return _adress; }
        public string GetDescription() { return _description;}
        public string GetPhone() { return _phone;}
        public string GetEmail() { return _email;}


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("Kopeika", "zxc", "qwe", "asd", "@gmail.com");
            shop.Print();

            string phone = shop.GetPhone();
            Console.WriteLine(phone);
        }
    }
}
