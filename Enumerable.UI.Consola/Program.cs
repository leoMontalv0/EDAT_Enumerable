internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=========================");
        Console.WriteLine("Enumerables");
        Console.WriteLine("=========================");

        #region Lista 
        var lista = new List<Productos>
        {
            new Productos
        };

    

        //foreach (var nombre in lista)
        //{
        //    Console.WriteLine(nombre);
        //}

        lista.OrderBy();

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        #endregion

        Console.ReadKey();
    }
}