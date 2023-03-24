using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS07
{
    internal class Animal
    {
        //atributos son variables
        private String raza;

        /*//metodos son miembros de la clase
        public void setRaza(String _raza)
        {
            this.raza = _raza;
            //this, estamos haciendo una referencia a esta clase
            //o a este objeto el es de la clase Animal

        }

        public String getRaza()
        {
            switch (raza)
            {
                case "Pitbull":
                    this.raza += " El perro es un tipo agresivo";
                    break;
                case "Labrador":
                    this.raza += " El perro es un buen cuidador";
                    break;
                case "Boxer":
                    this.raza += " El perro es amigable";
                    break;

                case null:
                    this.raza += "No definio ninguna raza de perro";
                    break;
                default:
                    this.raza +=" La raza del perro no esta definida";
                    break;
            }
            return this.raza;
        }*/

        public String Raza
        {
            set { raza = value; }
            get {
                switch (raza)
                {
                    case "Pitbull":
                        this.raza += " El perro es un tipo agresivo";
                        break;
                    case "Labrador":
                        this.raza += " El perro es un buen cuidador";
                        break;
                    case "Boxer":
                        this.raza += " El perro es amigable";
                        break;

                    case null:
                        this.raza += "No definio ninguna raza de perro";
                        break;
                    default:
                        this.raza += " La raza del perro no esta definida";
                        break;
                }
                return raza; }
        }



    }
}
