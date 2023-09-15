internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> openWith = new Dictionary<string, string>();
        openWith.Add("txt", "notepad.exe");
        openWith.Add("bmp", "paint.exe");
        openWith.Add("dib", "paint.exe");
        openWith.Add("rtf", "wordpad.exe");
        try
        {
            openWith.Add("txt", "notepad.exe");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Un elemento con la llave = \"txt\" ya existe.");

        }

        Console.WriteLine("");
        Dictionary<string, string>.KeyCollection KeyColl = openWith.Keys;
        foreach (string key in KeyColl)
        {
            Console.WriteLine(key);
        }


        Console.WriteLine("");
        foreach (KeyValuePair<string, string> pair in openWith)
        {
            Console.WriteLine("Llave {0} - Valor {1}", pair.Key, pair.Value);
        }

        Console.WriteLine("");
        Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
        foreach (string valor in valueColl)
        {
            Console.WriteLine(valor);
        }
        Console.WriteLine("");
        openWith.Remove("dib");
        foreach(string valor in valueColl){
            Console.WriteLine(valor);
        }

        Console.WriteLine("");
        if(openWith.ContainsKey("bmp")){
            Console.WriteLine("El tipo de formato esta soportado.");
        }
        Console.WriteLine("");
        openWith.Clear();
        Console.WriteLine("Total de datos en el diccionario:"+openWith.Count);
        Console.WriteLine("");
        if(openWith.ContainsValue("notepad")){
            Console.WriteLine("El valor se encuentra registrado.");

        }
        else{
            Console.WriteLine("El valor no se encuentra registrado.");
        }

        
        

    }
}