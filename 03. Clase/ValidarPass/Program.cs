int intentos = 0;
string contrasenia;
bool ingreso = true;

Console.WriteLine("Ingrese la contraseña");


while (ingreso)
{
    contrasenia = Console.ReadLine();
    intentos++;
    
    if(contrasenia.Equals("usSystem-2022"))
    {
       //ingreso = false;
        Console.WriteLine("Bienvenido a CoderHouse Dev");
        break;
    }
    else if (intentos >= 5)
    {
        Console.WriteLine("Su contrase no fue valida y agoto los intentos");
        break;
    }
    Console.WriteLine("Su contrase no fue valida, intente nuevamente");

}