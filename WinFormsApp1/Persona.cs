using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Person
    {
        NamePerson NamePerson { get; set; }

        DateTimePicker birthdate;

        public DateTimePicker Birthdate
        {
            
            get { return birthdate; } 



            set {birthdate = value;}
                 
        }

        public Person(NamePerson namePerson, DateTimePicker birthdate)
        {
           

            this.birthdate = birthdate;
           
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
