internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> openWith = new Dictionary<string, string>();
        //metodos Add: agrega la clave y el valor especificados al diccionario 
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
        //Porpiedad de keys, obtiene la coleccion que contiene la calve  
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
        //Propiedad de values:obtiene una coleccion que contiene los valores 
        Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
        foreach (string valor in valueColl)
        {
            Console.WriteLine(valor);
        }
        Console.WriteLine("");
        //Metodo remove Elimina un valor con la clave especificada
        openWith.Remove("dib");
        foreach(string valor in valueColl){
            Console.WriteLine(valor);
        }

        Console.WriteLine("");
        if(openWith.ContainsKey("bmp")){
            Console.WriteLine("El tipo de formato esta soportado.");
        }
        Console.WriteLine("");
        //Metodo clear: quita todas las claves y valores 
        openWith.Clear();
        Console.WriteLine("Total de datos en el diccionario:"+openWith.Count);// propiedad count
        Console.WriteLine("");
        //Metodo ContainsValue:Determina si Dictionary<TKey,TValue> contiene un valor específico.
        if(openWith.ContainsValue("notepad")){
            Console.WriteLine("El valor se encuentra registrado.");

        }
        else{
            Console.WriteLine("El valor no se encuentra registrado.");
        }

        
        

    }
}