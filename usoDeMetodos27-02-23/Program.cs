using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoDeMetodos27_02_23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> MisNombres = new List<Persona>();
            string i = "";
            do
            {

                var respuesta = IngresarPersona();
                MisNombres.Add(respuesta);
                Console.Clear();
                i = LeerDatos("Deseas realizar otro registro:");
            } while (i == "si");
            Imprimir(MisNombres);


        }
        public static Persona IngresarPersona()
        {
            string confirmacion = "";
            Persona persona = new Persona();
            persona.Nombres = LeerDatos("Ingresa tu nombre y apeido:");
            persona.Ciudad = LeerDatos("Ingresa tu ciudad:");
            persona.Sexo = LeerDatos("Sexo:");
            persona.Edad = Convert.ToInt32(LeerDatos("Ingresa tu edad"));
            persona.AptoParaVotar = ValidarEdad(persona.Edad);

            return persona;
        }
        public static string LeerDatos(string mensaje)
        {
            string xy = "";
            string datoLeidoDesdeTeclado = "";
            Console.WriteLine(mensaje);
            datoLeidoDesdeTeclado = Console.ReadLine();

            return datoLeidoDesdeTeclado;
        }
        public static bool ValidarEdad(int edad)
        {
            bool votacion = false && true;

            if (edad > 18)
            {
                Console.WriteLine("Apto para votar");

            }
            else
            {
                string answer = "";
                Console.WriteLine("No eres apto para votar!!!");
                answer = Console.ReadLine();
                votacion = true;

            }

            return votacion;
        }
        public static void Imprimir(List<Persona> personas)
        {
            int e = 0;
            int numeroIndice = 0;
            string concatenacion = "";
            foreach (var item in personas)
            {
                numeroIndice++;
                Console.WriteLine(numeroIndice + ".-" + item.Nombres + " " + item.Edad + " " + item.Ciudad + " " + item.Sexo + " " + item.AptoParaVotar);
            }

        }

    }
}
