// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//switch

string categoria = "H";

Console.WriteLine("Ingrese la categoria A, B, C o D");

//categoria = Console.ReadLine();

switch(categoria)
{
    case "A":
    case "D":
        Console.WriteLine("Empleado Administrativo");
        break;
    case "B":
        Console.WriteLine("Empleado Profesional");
        break;
    case "C":
        Console.WriteLine("Empleado Maestranza");
        break;
    default:
       // Console.WriteLine("Sin categoria");
        break;
}

//Escuela
string comision;
int calificacion;

Console.WriteLine("BIENVENIDOS A LA UNIVERSIDAD CODERHOUSE");
Console.WriteLine("INGRESE SU COMISION");

comision = Console.ReadLine();

switch (comision)
{
    case "A":
        Console.WriteLine("Turno mañana");
        break;
    case "B":
        Console.WriteLine("Turno tarde");
        break; 
    case "C":
        Console.WriteLine("Turno noche");
        break;
    default:
        Console.WriteLine("Sin turno fijo");
        break;
}

Console.WriteLine("Ingrese la nota del alumno");

calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion >= 0 && calificacion < 4)
{
    Console.WriteLine("Recursa");
}
else if (calificacion >= 4 && calificacion <= 7)
{
    Console.WriteLine("Aprobo la cursada");
}
else if (calificacion > 7 && calificacion <= 10)
{
    Console.WriteLine("Promociono la materia");
}
else
{
    Console.WriteLine("Calificar solo del 0 al 10");
}
