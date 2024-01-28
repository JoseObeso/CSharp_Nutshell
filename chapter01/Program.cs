internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" --- Bienvenidos ----");
        Console.WriteLine($" Resultado de Sumar es {Sumar(10, 5)}");
        Console.WriteLine($" Resultado de Restar es {Restar(10, 5)}");
        Console.WriteLine($" Resultado de Multiplicar es {Multiplicar(10, 5)}");
        Console.WriteLine("--- Cambio de Dolar a Soles");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Ingrese valor en Dolares");
        decimal dValorLeerDolares = Convert.ToDecimal(Console.ReadLine());
        decimal dPrecioDolar = 3.78M;
        Console.WriteLine($"El monto en Dolares de {dValorLeerDolares} a soles es : S/. {ConvertirAdolares(dValorLeerDolares)}");
        Console.WriteLine("--------- GRACIAS --------------");
        Console.WriteLine($" Saludos para {Saludos("Jose")}");
        Console.WriteLine("---------------------------------");

        string sMensaje = "Bienvenidos al sistema";

        Console.WriteLine($"El mensaje en mayuscula seria {ConvertirAMayuscula(sMensaje)}");

        Console.WriteLine(sMensaje.ToUpper() + dPrecioDolar);
        
 
         // forma de definir una funcion en dotnet 8 -- se ha simplificado

        int Multiplicar(int a, int b) => a * b;
        int Sumar(int a, int b) => a + b;
        int Restar(int a, int b) => a - b;
        decimal ConvertirAdolares(decimal dValor) => dValor * dPrecioDolar;
        string Saludos(string sNombre) => "Hola " + sNombre;

        string ConvertirAMayuscula(string sMensajeRecibir) => sMensajeRecibir.ToUpper();







    }
}