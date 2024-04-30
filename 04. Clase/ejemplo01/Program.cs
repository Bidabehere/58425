int  sumar(int _num1, int _num2)
{
    return _num1 + _num2;
}



Console.WriteLine("Ingrese los numero a sumar");

Console.WriteLine("Ingrese el primer numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
int num2 = int.Parse(Console.ReadLine());

int total = sumar(num1, num2);

Console.WriteLine("El total de la suma es:" + total);
