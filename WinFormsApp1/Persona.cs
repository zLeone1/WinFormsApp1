using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Person : NamePerson
    {
       

        DateTime birthdate;

        public DateTime Birthdate
        {
            
            get { return birthdate; } 



            set {birthdate = value;}
                 
        }

        public Person(string name, string motherlastname, string lastname, DateTime birthdate) : base (name, motherlastname, lastname)
        {
           

            this.birthdate = birthdate;
           
        }

        public override string ToString()
        {
            return  base.ToString() + $" \n Birth Date: {birthdate} ";
        }
    }
}
