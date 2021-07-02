using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // un conjunto de variables
            Tamagotchi mimascota=new Tamagotchi();
            
            // cada cierto tiempo (si no hago nada)
            // baja el comer
            // incrementa el bao.
            // el afecto baja.
            // enfermedad incrementa
            // cansancio.
        }
    }

    class Tamagotchi
    {
        // campos
        public int comer=100;
        public int baño = 0;
        public int afecto = 50;
        public int enfermedad = 0;
        public int cansancio = 0;

        // funcion.
        public void NoHagoNada()
        {
            comer=comer-1;
            baño=baño+1;
            afecto=afecto-1;
            if(baño>50) { 
                enfermedad=enfermedad+1;
            }
            cansancio=cansancio+1;
        }
        public void Comer()
        {
            if(afecto>0) {                 
                comer=100;
            }
            // si el afecto es negativo entonces no va a comer.
        }
    }

}
