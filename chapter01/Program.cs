namespace chapter01.masterclases;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" --- Bienvenidos ----");
        #region 
        /*
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
        bool bMayoredad = true;
        Console.WriteLine($"Es mayor de Edad {EsMayorEdad(20)}");
        int Multiplicar(int a, int b) => a * b;
        int Sumar(int a, int b) => a + b;
        int Restar(int a, int b) => a - b;
        decimal ConvertirAdolares(decimal dValor) => dValor * dPrecioDolar;
        string Saludos(string sNombre) => "Hola " + sNombre;
        string ConvertirAMayuscula(string sMensajeRecibir) => sMensajeRecibir.ToUpper();
        string EsMayorEdad(int iedad)
        {
            if (bMayoredad)
            {
                return "Si es Mayor de Edad" + iedad;
            }
            else
                return "No es es Mayor de Edad" + iedad;
        }
        */
        #endregion

        int iMontoIngresado = 10;

        /* ejemplo con clase en el mismo archivo */
        ConvertirSolesaPuntos VerificarMonto = new ConvertirSolesaPuntos(); // inicializamos la clase
        string sValidar = VerificarMonto.VerificarSiesElMontoCorrecto(iMontoIngresado); //  usamos su metodo
        bool BConfirma = VerificarMonto.bVerifica(iMontoIngresado); //  realizamos las operacion

        
        Console.WriteLine(sValidar);
        if (BConfirma)
        {
            Console.WriteLine("-- SI PUEDE JUGAR");
        }
        else
        {
            Console.WriteLine(" --  NO PUEDE JUGAR");
        }
        // Ejemplo con clase de un archivo diferente masterclases -- se llama usandola directiva namespace
        GanarPremio VerificarPremio = new GanarPremio(); // inicializamos las clases
        string sGano = VerificarPremio.Premio(iMontoIngresado); // usamos su metodo : Premio
        Console.WriteLine(sGano); // ejecutamos las operaciones

    }

    //  Definicion de clases en el mismo archivo, pero separado del metodo main
    
    public class ConvertirSolesaPuntos
    {
        public string VerificarSiesElMontoCorrecto(int iIndicador)
        {
            if (iIndicador < 20)
            {
                return "Monto Incorrecto";
            }
            {
                return "Monto Conforme";
            }
        }
        public bool bVerifica(int iIndicador)
        {

            if (iIndicador < 20)
            {
                return false;
            }
            {
                return true;
            }
        }
    }



}