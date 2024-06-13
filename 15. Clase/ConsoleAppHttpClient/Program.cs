

namespace ConsoleAppHttpClient
{
    class Program
    {
        static async Task Main(string[] args)
        {

            string url = @"https://localhost:7074/api/Cliente";

            ConsumoApis clienteHttp = new ConsumoApis(url);

            List<Cliente> clientes = await clienteHttp.FiltrarAsync();

            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Cliente: {cliente.Nombre}");
            }

            Console.WriteLine("---------- Modificar ----------");

            Cliente cliente1 = new Cliente(); 
            cliente1.id = 12;
            cliente1.Nombre = "Diego";
            cliente1.Apellido = "Lopez";
            cliente1.Domicilio = "Camino Cintura 2500";
            cliente1.Telefono = "123123123132";

           // bool respuesta = await clienteHttp.ModificarCliente(cliente1);

            //Console.WriteLine(respuesta);

            Console.WriteLine("---------- Crear Cliente ----------");

            Cliente clienteNew = new Cliente();

            clienteNew.Nombre = "Lucho";
            clienteNew.Apellido = "Lopez";
            clienteNew.Domicilio = "Camino Cintura 22500";
            clienteNew.Telefono = "+123123123132";

            bool respuesta = await clienteHttp.AltaCliente(clienteNew);
            
            Console.WriteLine(respuesta);

            Console.WriteLine("---------- Eliminar Cliente ----------");

            respuesta = await clienteHttp.EliminarCliente(13);

            Console.WriteLine(respuesta);
            Console.ReadLine();
        }
    }
}
