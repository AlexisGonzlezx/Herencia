using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{

    class Persona
        {
            protected double Nombre;

            public double nombre
            {
                get
                {
                    return nombre;
                }
                set
                {
                    nombre = value;
                }
            }

            public Persona
            ()

            {
            nombre = "" ;
            }
            public Persona(double nombre)

            {
                this.nombre = nombre;
            }
         
            public override string ToString()
            {
                return "" + nombre;
            }
        }

    }







