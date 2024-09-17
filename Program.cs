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

    opcion = Console.ReadLine().ToUpper();

    int numero = 0;

    switch (opcion)
    {
        case "A":
            Console.WriteLine("Ingresa un número");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Es valor del número insertado");
            ConsultarNumero(numero);
            break;

        case "B":
            Console.WriteLine("ingrese un valor del 1 al 7");
            numero = Convert.ToInt32(Console.ReadLine());
            MostrarDiaSemana(numero);
            break;

        case "C":
            Console.WriteLine("");
            break;

        case "D":
            Console.WriteLine("");
            break;

        case "E":
            Console.WriteLine("");
            break;

        case "F":
            Console.WriteLine("");
            break;

        case "G":
            Console.WriteLine("");
            break;


        default:
            break;
    }





    Console.WriteLine(" ");
    Console.WriteLine("=============================================== ");
    Console.WriteLine(" ");

} while (opcion!="S");





//B
void MostrarDiaSemana(int valor)
{
    //string valor2 = Convert.ToString(numero);
    switch (valor)
    {
        case 1:
            Console.WriteLine("Día elegido es: LUNES ");
            break;
        case 2:
            Console.WriteLine("Día elegido es: MARTES ");
            break;
        case 3:
            Console.WriteLine("Día elegido es: MIERCOLES");
            break;
        case 4:
            Console.WriteLine("Día elegido es: JUEVES ");
            break;
        case 5:
            Console.WriteLine("Día elegido es: VIERNES ");
            break;
        case 6:
            Console.WriteLine("Día elegido es: SÁBADO ");
            break;
        case 7:
            Console.WriteLine("Día elegido es: DOMINGO ");
            break;
        default:
            break;
    }
}


//A
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