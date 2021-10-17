using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    {
        class Alumno : Persona
        {
            private double matricula;
            private string carrera;
        public double Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }
        public string Carrera
            {
                get
                {
                    return carrera;
                }
                set
                {
                    carrera = value;
                }
            }
           

            public Alumno()
            {
                matricula = "";
                carrera = "";
            }

            public Alumno(String carrera, double matricula)
            {
                this.carrera = carrera;
                this.matricula = matricula;
            }

            public override string ToString()
            {
                return base.ToString() + "" + matricula + "" + carrera.ToString();
            }

        }


    }

}
}
