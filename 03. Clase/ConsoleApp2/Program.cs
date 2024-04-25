int cantidadDeNotas = 0;
double promedioNotas = 0;
double nota;
double sumaNotas  = 0;

Console.WriteLine("Ingrese la cantidad de notas a calcular");
cantidadDeNotas = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidadDeNotas; i++)
{
    Console.WriteLine("Ingrese la nota");
    nota = double.Parse(Console.ReadLine());
    sumaNotas = sumaNotas + nota;
}
promedioNotas = sumaNotas / cantidadDeNotas;

Console.WriteLine("El promedio de los alumnos cargados es: {0}", promedioNotas);


int numero;

Console.WriteLine("Ingrese un numero para clasificar");
Console.WriteLine("Para salir ingrese 0");
numero = int.Parse(Console.ReadLine());

while (numero != 0)
{
    if (numero > 0)
    {
        Console.WriteLine("Numero positivo");
    }
    else
    {
        Console.WriteLine("Numero negativo");
    }

    Console.WriteLine("Ingrese un numero para clasificar");
    Console.WriteLine("Para salir ingrese 0");
    numero = int.Parse(Console.ReadLine());

}


int numeroTopeMultiplos;

Console.WriteLine("Ingrse el numero tope para calcular los multiplos");
numeroTopeMultiplos = int.Parse(Console.ReadLine());

Console.WriteLine("Los multiplos de 5 son: ");

for (int i = 1; i <= numeroTopeMultiplos; i++)
{
    if(i % 5 == 0)
    {
        Console.Write(i + ", ");
    }
}