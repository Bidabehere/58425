// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Supongamos que debemos hacer un control básico del stock de nuestros productos en un depósito.
//Nos brindan la cantidad de productos en depósito y la cantidad de productos vendidos. Entonces debemos preguntarnos si no existen productos en nuestro depósito, entonces debemos reponerlos.  
//Aquí utilizamos Console.ReadLine() para obtener la cantidad a vender y seguir trabajando con variables, en la cual como dicha función retorna un string y la cantidad es un entero tuvimos que convertir utilizando la función Convert que me permite convertir entre diversos tipos de datos.

int cantidadProductosVendidos;
int cantidadProductosDeposito = 50;
int stock;

Console.WriteLine("Ingrese la cantidad de productos vendidos.");

cantidadProductosVendidos =  Convert.ToInt32(Console.ReadLine());

stock = cantidadProductosDeposito - cantidadProductosVendidos;

if (stock == 0)
{
    Console.WriteLine("Reponer stock de productos");
    //cantidadProductosDeposito += 10;
    cantidadProductosDeposito = cantidadProductosDeposito + 10;
    Console.WriteLine("Productos cargados al deposito");
}
else
{
    if(stock <= 5)
    {
        Console.WriteLine("Stock minimo, reponer productos");
        cantidadProductosDeposito += 5;
        Console.WriteLine("Productos cargados al deposito");
        Console.WriteLine("Informar a ventas {0} productos sin vender", stock);
    }
    else
    {
        Console.WriteLine("Informar a ventas {0} productos sin vender.", stock);
    }
    
};

