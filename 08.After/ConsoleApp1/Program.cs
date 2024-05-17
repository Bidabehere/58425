// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    int numero = Convert.ToInt32(Console.ReadLine());
    decimal division = 25 / numero;
    Console.WriteLine(division);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}
