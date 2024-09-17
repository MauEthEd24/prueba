// See https://aka.ms/new-console-template for more information

string opcion = "";
do
{
    Console.WriteLine("INGRESA UNA DE LAS SIGUIENTES OPCIONES");
    Console.WriteLine("======================================");
    Console.WriteLine("A) Determinar si el número es positivo, negativo o cero ");
    Console.WriteLine("B) Identificar el día de la semana");
    Console.WriteLine("C) Sumar los 100 primeros números naturales");
    Console.WriteLine("D) Imprimer los números del 1 al ingresado por usuario");
    Console.WriteLine("E) Calcular el área del circulo, ingresando el valor del RADIO");
    Console.WriteLine("F) Mostrar los elementos de un arreglo unidimensional (PROC).");
    Console.WriteLine("G) Mostrar los nombres de personas almacenados en una lista predefinida");
    Console.WriteLine("S) Salir");

    opcion = Console.ReadLine();

    int numero = 0;

    switch (opcion)
    {
        case "A":
            Console.WriteLine("Ingresa un número");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Es valor del número insertado");
            ConsultarNumero(numero);
            break;

        default:
            break;
    }





    Console.WriteLine(" ");
    Console.WriteLine("=============================================== ");
    Console.WriteLine(" ");

} while (opcion!="S");




//a
int ConsultarNumero(int numero)
{
    if (numero == 0)
    {
        Console.WriteLine($"es número insertado es CERO {numero}");
    }
    else if (numero > 0)
    {
        Console.WriteLine($"es número insertado {numero} es positivo");
    }
    else if (numero < 0) 
    {
        Console.WriteLine($"es número insertado {numero} es negativo");
    }
    else
    {
        Console.WriteLine($"no es un número lo que ingresó");
    }
    return numero;
}



Console.Read();


//commit >> confirmar
//push >> enviar