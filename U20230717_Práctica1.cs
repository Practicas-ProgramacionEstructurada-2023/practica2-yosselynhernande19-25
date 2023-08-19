using System;
using System.ComponentModel;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

         //Declarando de variables de texto capturando desde la terminal
          string? nombre;
          string? apellido;

          //Declaracion de variables de texto desde codigo
          string? condigo_estudiantil = "U20230717";
          string? becado = "Si";

          //Declaracion de variables de tipo enteras capturando desde la terminal
          int edad;

          //Declaracion de variables de tipo enteras desde codigo
          int AñoIngreso = 2023;
          int AñoEgreso =2025;

          //Declaracion de variables double capturando desde la terminal 
          double mensualidad;

          //Declaracion de variables decimales desde codigo 
          double transporte = 1.70;
          double alimentacion = 3.00;

          //Declaracion de variables de tiempo a time
          DateTime fechaActual = DateTime.Now;
          DateTime Fechaespecifica = new DateTime(23,8,19,16,20,0,0);

          //Obtencion de datos de terminal
          Console.WriteLine("Ingrese su nombre: ");
          nombre = Convert.ToString(Console.ReadLine());
          Console.WriteLine();

          Console.WriteLine("Ingrese su apellido: ");
          apellido = Convert.ToString(Console.ReadLine());
          Console.WriteLine();

          Console.WriteLine("Ingrese su edad: ");
          edad = Convert.ToInt32(Console.ReadLine());
        
          Console.WriteLine("Ingrese su mensualidad universidad");
          mensualidad = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("********************Inicio de Impresion*****************");
          //Impresion de datos 
          Console.WriteLine("su nombre:" + nombre);
          Console.WriteLine("Su apellido es:" + apellido);
          Console.WriteLine("Su codigo estudiantil es: " + condigo_estudiantil);
          Console.WriteLine("Es becado?" + becado);
          Console.WriteLine("Su edad es:" + edad);
          Console.WriteLine("Su año de ingreso:" + AñoIngreso);
          Console.WriteLine("Su año de Egreso:" + AñoEgreso);
          Console.WriteLine("Su  mensualidad universitaria es:" + mensualidad);
          Console.WriteLine("Su gasto diario de transporte es:" + transporte);
          Console.WriteLine("Su gasto diario de alimentacion es:" + alimentacion);
          Console.WriteLine(" la fecha y tiempo de impresion de datos es:" + fechaActual);
          Console.WriteLine("La fecha que termina la practtica es" + Fechaespecifica);
          Console.WriteLine("***********************Fin de Impresion********************");

           Console.WriteLine("**************Inicio de Impresion*****************");
          //Aplicacion de funciones de cadena 

          //Funcion de comparacion de cadenas de texto
          bool cadenaComparativa= nombre == apellido;

          //Funcion de Minuscula
          String? funcionMayuscula1 = nombre.ToLower();
          string?  funcionMinuscula2 = apellido.ToUpper();

          //Funcion de Mayuscula
          String? FuncionMayuscula1 = nombre.ToUpper();
          String? funcionMayuscula2 = apellido.ToUpper();

          //Funcion Concatenado
          String? cadenaConcatenado = nombre + "" + apellido;
           
        //Funcion de tamaño de cadena
        int llogintudCadena1=nombre.Length;
        int llogintudCadena2=apellido.Length;

        Console.WriteLine("Comparacion : " + cadenaComparativa);
        Console.WriteLine("Mayusculas Nombre y Apellido: " + funcionMayuscula1 + " " + funcionMayuscula2);
        Console.WriteLine("Minuscula Nombre y Apellido: " + funcionMinuscula2 + " " + funcionMinuscula2);
        Console.WriteLine("Concatenacion: " + cadenaComparativa);
        Console.WriteLine("la longitud de datos de nombre es: " + llogintudCadena1);
        Console.WriteLine("la longitud de datos de apellido es: "  + llogintudCadena2);
        Console.WriteLine("*********************Fin de Impresion*****************+");

        


        

    





        }
    }
}
