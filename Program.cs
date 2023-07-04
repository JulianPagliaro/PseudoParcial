using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Pseudo_Parcial
{
    static void Main()
    {
        int Area; // Valor del área que almacena la información en un entero, tanto de la parte entera del área como de dos decimales.
        int Volumen; // Valor del volumen que almacena la información en un entero, tanto de la parte entera del área como de dos decimales.
        double Generatriz;
        double Altura;
        double Radio;
        double Area_redondeada; // Valor del área que expresa correctamente la parte entera y decimal (dos decimales).
        double Volumen_redondeado; // Valor del volumen que expresa correctamente la parte entera y decimal (dos decimales).

        Console.WriteLine("A continuación se le solicitarán algunas de las dimensiones del cono, recordar que ni la altura, ni la generatriz, ni el radio pueden ser negativos, en caso de ingresar un valor inválido, se le solicitará volver a ingresarlo.");

        do
        {
            Console.Write("Ingrese el valor del Radio en centímetros: ");
            Radio = double.Parse(Console.ReadLine());
            if (Radio < 0)
            {
                Console.WriteLine("Valor inválido");
            }
        } while (Radio <= 0);

        do
        {
            Console.Write("Ingrese el valor de la Generatriz en centímetros: ");
            Generatriz = double.Parse(Console.ReadLine());
            if (Generatriz < 0)
            {
                Console.WriteLine("Valor inválido");
            }
        } while (Generatriz <= 0);

        do
        {
            Console.Write("Ingrese el valor de la Altura en centímetros: ");
            Altura = double.Parse(Console.ReadLine());
            if (Altura < 0)
            {
                Console.WriteLine("Valor inválido");
            }
        } while (Altura <= 0);

        Area = (int)(Math.Round(Math.PI * Radio * (Radio + Generatriz) * 100)); // Corro dos decimales hacia la parte entera y lo almaceno en un entero.
        Volumen = (int)(Math.Round(((Math.PI * Math.Pow(Radio, 2) * Altura) / 3) * 100)); // Corro dos decimales hacia la parte entera y lo almaceno en un entero.

        Area_redondeada = Area / 100.0; // Desplazo los decimales que se almacenaron en la parte entera hacia su posición decimal correcta.
        Volumen_redondeado = Volumen / 100.0; // Desplazo los decimales que se almacenaron en la parte entera hacia su posición decimal correcta.

        Console.WriteLine("El área del cono es de: " + Area_redondeada + " centímetros cuadrados");
        Console.WriteLine("El volumen del cono es de: " + Volumen_redondeado + " centímetros cúbicos");
    }
}

