using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscopos
{
    internal class Signo
    {
        public DateTime fechainicio { get; set; }
        public DateTime fechafinal { get; set; }
        public String nombre { get; set; }

        public Signo(DateTime i ,DateTime f, String n) {
            this.fechainicio = i;

            this.fechafinal = f;
            this.nombre = n;
        }
        public override string ToString()
        {
            return $"Signo: {nombre},fecha inicio:{fechainicio.ToString("dd/MM/yyyy")},fecha final :{fechafinal.ToString("dd/MM/yyyy")}";     
            // return  fechainicio.ToString()+fechafinal.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Signo[] signos = new Signo[3];
            /*
            {
                new Signo { fechainicio = new DateTime(1,7,22), fechafinal = new DateTime(1,8,21),nombre="Leo" },
                new Signo { fechainicio = new DateTime(1,1,22), fechafinal = new DateTime(1,2,21),nombre="Acuario" },
                new Signo { fechainicio = new DateTime(1,2,22), fechafinal = new DateTime(1,3,21),nombre="Piscis" },

            };
            */

            signos[0]= new Signo(new DateTime(1, 7, 22) ,new DateTime(1, 8, 21), "Leo");
            signos[1] = new Signo(new DateTime(1, 1, 22), new DateTime(1, 2, 21), "acuario");
            signos[2] = new Signo(new DateTime(1, 2, 22), new DateTime(1, 3, 21), "piscis");

            Array.Sort(signos,(x,y)=>DateTime.Compare(x.fechainicio, y.fechainicio));
            //Array.Sort(signos,(x,y)=>x.fechainicio.CompareTo(y.fechainicio));
            String[] bienestar = new string[3] {"no pain no gain","tendras calma en tu vida","loool" };
            String[] dinero = new String[3] { "pesos", "dolares", "guaranies" };
            String[] amor = new string[3] { "mucho", "poco", "maso" };
            for (int i = 0; i <signos.Length; i++)
            {
                Console.WriteLine(signos[i]);
            }
            
            Console.WriteLine("Ingrese su nombre");
            String nom=Console.ReadLine();
            Console.WriteLine("ingrese dia de nacimiento");
            Int32.TryParse(Console.ReadLine(),out int  dia);
            Console.WriteLine("ingrese dia mes de nacimiento");
            Int32.TryParse(Console.ReadLine(), out int mes);
            DateTime persona = new DateTime(1, mes, dia);
            persona.ToString("dd/MM/yyyy");
            Console.WriteLine(persona);
           


            if (persona.Date >= signos[0].fechainicio && persona.Date <= signos[0].fechafinal)
            {
                Console.WriteLine("La persona es de " + signos[0].nombre);
                Random rdm = new Random();
                int indice = rdm.Next(bienestar.Length);
                String aleatorio = bienestar[indice];
                Console.WriteLine(aleatorio);
            }
            else if (persona.Date >= signos[1].fechainicio && persona.Date <= signos[1].fechafinal)
            {
                Console.WriteLine("La persona es de " + signos[1].nombre);
                Random rdm = new Random();
                int indice = rdm.Next(bienestar.Length);
                String aleatorio = bienestar[indice];
                Console.WriteLine(aleatorio);
            }
            else if (persona.Date >= signos[2].fechainicio && persona.Date <= signos[2].fechafinal)
            {
                Console.WriteLine("La persona es de " + signos[2].nombre);
                Random rdm = new Random();
                int indice = rdm.Next(bienestar.Length);
                String aleatorio = bienestar[indice];
                Console.WriteLine(aleatorio);
            }





        }
    }
}
