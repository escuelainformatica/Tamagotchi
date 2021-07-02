using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Tamagotchi
    {
        // campos
        public int comer = 100;
        public int baño = 0;
        public int afecto = 50;
        public bool enfermo = false;
        public int salud = 100;
        public int cansancio = 0;
        public bool encendida; // true, false
        public bool vivo = true;

        public void MostrarEstatus(Form1 form)
        {
            form.textBoxComer.Text=comer.ToString();
            form.textBoxBaño.Text =baño.ToString();
            form.textBoxAfecto.Text = afecto.ToString();
            form.textBoxCansancio.Text = cansancio.ToString();

            /*Console.WriteLine("comer :" + comer);
            Console.WriteLine("baño :" + baño);
            Console.WriteLine("afecto :" + afecto);
            Console.WriteLine("enfermedad :" + enfermo);
            Console.WriteLine("cansancio :" + cansancio);
            */
        }
        // funcion.
        public void NoHagoNada()
        {
            if (vivo == false)
            {
                // si no esta vivo (esta muerto), salir de la funcion 
                return;
            }

            comer = comer - 1; // tener hambre
            baño = baño + 1; // aumenta ir al baño
            afecto = afecto - 1; // el afecto baja
            if (salud < 0)
            {
                Console.WriteLine("se murio por salud");
                vivo = false;
            }
            if (enfermo)
            {
                salud--; // si esta enfermo, entonces baja su salud.
            }
            if (baño > 50)
            {
                enfermo = true; // si baño>50 entonces aumenta la enfermedad
            }
            if (encendida)
            {
                cansancio = cansancio + 1; // cansancio aumento.
            }
            else
            {
                cansancio = cansancio - 1; // descansar
            }
            if (comer == 0)
            {
                Console.WriteLine("se murio por hambre");
                vivo = false;
            }
        }
        public void Comer()
        {
            if (afecto > 0)
            {
                comer = 100;
            }
            // si el afecto es negativo entonces no va a comer.
        }
        public void IrAlBaño()
        {
            baño = 0;
        }
        public void DarAfecto()
        {
            if (cansancio != 0)
            {
                // Solo acepta afecto si no esta cansado.
                afecto = 50;
            }
        }
        public void CurarEnfermedad()
        {
            enfermo = false; // ya no esta enfermo
        }
        public void ApagarLuz()
        {
            encendida = false;
        }
        public void EncenderLuz()
        {
            encendida = true;
        }


    }

}
