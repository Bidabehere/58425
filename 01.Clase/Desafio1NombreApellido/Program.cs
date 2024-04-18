// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.WriteLine("Bienvenidos!");

string nombre;
nombre = "Juan";

const int dni = 123212521;


Console.WriteLine("Mi nombre es: " +  nombre);

string apellido = "Bida";

Console.WriteLine("Mi apellido es: " + apellido);


Console.WriteLine("Mi DNI es: " + dni);

///////// Ejemplo 2
///
int num1;
int num2;

Console.WriteLine("Ingrese el primer numero a sumar.");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero a sumar.");
num2 = Convert.ToInt32(Console.ReadLine());

int total = num1 + num2;
Console.WriteLine("El total de la suma es: " + total);

///Console.WriteLine("Mi nombre es {0} {1} {2}.", nombre, "El Profe", apellido);

string mensaje = $"Mi nombre es {nombre} \"El Profe\" {apellido}";

Console.WriteLine(mensaje);


Console.ReadKey();