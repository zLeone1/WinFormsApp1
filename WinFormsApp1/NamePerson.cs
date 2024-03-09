using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
      class NamePerson
    {
        protected string name;
        public string Name 
        {
            get
            { return name; }
            set 
            {
                name = value;
            }
        } 

        private string lastname;
        public string Lastname
        {
            get
            { return lastname; }
            set
            {
                lastname = value;
            }
        }
        protected string motherlastname;

        public string MotherLastname
        {
            get
            { return motherlastname; }
            set
            {
                motherlastname = value;
            }
        }
        public override string ToString()
        {
            return  $" Name: {name} \n Last Name: {lastname} \n Mother Last Name: {motherlastname} ";
        }


        public NamePerson(string name, string motherlastname, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
            this.motherlastname = motherlastname;
        }

       
    }
}
