namespace ejercicio49
{
    public class ejercicio49
    {
        public static void Main()
        {
            int num1;
            int num2;
            string respuesta;
            int result;

            Console.WriteLine("ingrese el primer numero");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            num2=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la operacion que desea hacer, s si es suma y r si es resta");
            respuesta= (Console.ReadLine());

            switch (respuesta)
            {
                case "s":

                    result= num1+ num2;
                    Console.WriteLine($"el resultado de la suma es {result} ");
                    break;

                case "r":

                    result = num1 - num2;
                    Console.WriteLine($"el resultado de la resta es {result} ");
                    break;
            }



        
        }
    }
}
