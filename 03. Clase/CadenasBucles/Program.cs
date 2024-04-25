string cadenaNula = null;
string cadenaVacia = string.Empty;
string cadenaSaludo = "Hola, Soy una cadena...";

Console.WriteLine(cadenaSaludo + cadenaNula + cadenaVacia);

if (cadenaNula == cadenaVacia)
{
    Console.WriteLine("Las cadenas son iguales!");
}
else
{
    Console.WriteLine("Las cadenas no son iguales!");
}


//Console.WriteLine(cadenaNula.Length);
Console.WriteLine(cadenaVacia.Length);
Console.WriteLine(cadenaSaludo.Length);

string mensaje = "Voy a desarrollar en C#";

Console.WriteLine("Mensaje en minusculas: " + mensaje.ToLower());
Console.WriteLine("Mensaje en mayusculas: " + mensaje.ToUpper());

int numeroEntero = 22;
double numeroConDecimales = 1.88;
bool booleano = true;

//Console.WriteLine(numeroEntero.ToString() + numeroConDecimales.ToString() + booleano.ToString());


string cadena1 = "Soy una cadena ";
string cadena2 = "Soy una cadena";

if (cadena1.Equals(cadena2))
{
    Console.WriteLine("Cadena1 es igual a cadena 2 ");
}else
{
   Console.WriteLine("Cadena1 no es igual a cadena 2 ");
}

if (cadena1.Contains(cadena2))
{
    Console.WriteLine("Cadena1 contiene a cadena 2 ");
}
else
{
    Console.WriteLine("Cadena1 no contiene a cadena 2 ");
}

Console.WriteLine("Ingrese un numero para sumar.");

string cadena = Console.ReadLine();

double constante = 0.5;

double numeroEnCadenaConvertidoADouble;

double sumaConNumeroDouble;

if (String.IsNullOrEmpty(cadena))
{
    Console.WriteLine("La cadena no se parsear ya que esta vacia.");
}
else
{
    numeroEnCadenaConvertidoADouble = double.Parse(cadena);
    sumaConNumeroDouble = numeroEnCadenaConvertidoADouble + constante;
    Console.WriteLine("El resultado es: " +  sumaConNumeroDouble);
}
