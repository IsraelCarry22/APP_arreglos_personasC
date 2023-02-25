using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_16_02_23;

namespace WindowsFormsApp_16_02_23
{
    class Contac : Person
    {
        private String telephone;
        private String gmail;

        public string Telefono
        {
            get { return telephone; }
            set
            {
                telephone = value.Replace(" ", "").Replace("-", "");
            }
        } 

        public String Correo
        {
            get { return gmail; }
            set { gmail = value; }
        }

        public Contac() : base()
        {
            telephone = string.Empty;
            gmail = string.Empty;
        }

        public Contac(string name, string last_name_father, string last_name_mother, DateTime? birthdate, string telephone, string gmail) : base(name, last_name_father, last_name_mother, birthdate)
        {
            this.telephone = telephone;
            this.gmail= gmail;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTelefono: " + telephone + "\nCorreo: " + gmail;
        }
    }
}