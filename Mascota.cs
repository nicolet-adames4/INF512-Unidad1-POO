using System;

namespace INF512_Unidad1_POO
{
    class Mascota
    {
        // Atributos
        public string Nombre;
        public string Tipo;
        public int Edad;

        // Datos de la mascota
        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Edad: " + Edad + " años");
        }

        // Método de comportamiento
        public void Comer()
        {
            Console.WriteLine(Nombre + " está comiendo");
        }
    }
}
public void Dormir()
{
    Console.WriteLine(Nombre + " está durmiendo");
}

