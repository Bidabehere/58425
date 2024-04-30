
bool validarContrasenia(string contrasenia)
{
    return contrasenia.Equals(" ");
}
string ocultarPass(string pass)
{
    char[] caracteres = pass.ToCharArray();

    for (int i = 0; i < caracteres.Length; i++)
    {
        caracteres[i] = '*';
    }
    string textoModificado = new string(caracteres);
    
    return textoModificado;
}


void validoIngreso()
{

    int intentos = 0;
    string contrasenia;
    bool ingreso = true;

    Console.WriteLine("Ingrese la contraseña");


    while (ingreso)
    {
        contrasenia = Console.ReadLine();
        intentos++;

        if (validarContrasenia(contrasenia))
        {
            string passOculto = ocultarPass(contrasenia);
            Console.WriteLine("Bienvenido a CoderHouse Dev");
            Console.WriteLine("Su contraseña es correcta {0}", passOculto);
            break;
        }
        else if (intentos >= 5)
        {
            Console.WriteLine("Su contrase no fue valida y agoto los intentos");
            break;
        }
        int restoDeIntentos = 5 - intentos;
        Console.WriteLine("Su contrase no fue valida, intente nuevamente. Le quedan {0} intentos.", restoDeIntentos);

    }

}


validoIngreso();