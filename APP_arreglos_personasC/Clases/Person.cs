using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_16_02_23
{
    class Person
    {
        protected String name;
        protected String last_name_father;
        protected String last_name_mother;
        protected DateTime? birthdate;

        public String Nombre
        {
            get { return name; }
            set { name = value; }
        }

        public String Apellido_Paterno
        {
            get { return last_name_father; }
            set { last_name_father = value; }
        }

        public String Apellido_Materno
        {
            get { return last_name_mother; }
            set { last_name_mother = value; }
        }

        public DateTime? Fecha_de_cumpleaños
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public int Edad
        {
            get
            {
                int age;
                age = (DateTime.Now.Year - birthdate.Value.Year);
                return age;
            }
        }

        public Person()
        {
            name = String.Empty;
            last_name_father = String.Empty;
            last_name_mother = String.Empty;
            birthdate = null;
        }
        public Person(String name, String last_name_father, String last_name_mother, DateTime? birthdate)
        {
            this.name = name;
            this.last_name_father = last_name_father;
            this.last_name_mother = last_name_mother;
            this.birthdate = birthdate;
        }

        public override string ToString()
        {
            return "Nombre Completo: " + name.ToUpper() + " " + last_name_father.ToUpper() + " " + last_name_mother.ToUpper() + " " + "\nEdad: " + Edad + "\nFecha cumpleaños: " + birthdate;
        }
    }
}