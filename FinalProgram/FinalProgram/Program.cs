
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_menu
{
    public class Program
    {
        static void ejercicio1()
        {
            Console.WriteLine("Hola Mundo");
            Console.ReadLine();
        }
        static void ejercicio2() {
            try
            {
                int num1;
                int num2;
                int suma;
                int resta;
                int multiplicacion;
                double modulo;
                Console.WriteLine("Vamos a hacer operaciones.\nIntroduzca el primer numero \n");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo numero ");
                num2 = Convert.ToInt32(Console.ReadLine());
                suma = num1 + num2;
                resta = num1 - num2;
                multiplicacion = num1 * num2;
                modulo = num1 % num2;
                Console.WriteLine("La suma de {0} y {1} es " + suma, num1, num2);
                Console.WriteLine("La resta de {0} y {1} es " + resta, num1, num2);
                Console.WriteLine("La multiplicacion de {0} y {1} es " + multiplicacion, num1, num2);
                Console.WriteLine("El modulo de {0} y {1} es " + modulo, num1, num2);
            }
            catch (FormatException letra) {
                Console.WriteLine("Ups! Caracter no admitido. La proxima deberias probar con un numero!");
            }

        }
        static void ejercicio3()
        {
            try
            {
                int num1;
                int num2;
                Console.WriteLine("Vamos a comparar numeros!");
                Console.WriteLine("Introduzca un numero entero positivo");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca otro numero entero positivo ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num1<0 || num2<0) { 
                    Console.WriteLine("GAME OVER! \nUno de los numeros es negativo.Vuelva a intentarlo.");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("{0} es menor que {1}", num1, num2);
                }
                else
                {
                    Console.WriteLine("{0} es mayor que {1}", num1, num2);
                }
            }
            catch (FormatException letra)
            {
                Console.WriteLine("Ups! Caracter no admitido. La proxima deberias probar con un numero!");

            }
        }
        static void ejercicio4()
        {
            try
            {
                int num1;
                int num2;
                Console.WriteLine("Sera par? Veamoslo.\nIntroduzca un numero entero positivo");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca otro numero entero positivo ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num1<0 || num2<0) { 
                    Console.WriteLine("GAME OVER! \nUno de los numeros es negativo.Vuelva a intentarlo.");
                }else if(num1%2 == 0 && num2%2 == 0) { 
                     Console.WriteLine("Ambos numeros son pares!");
                }else if(num1%2 != 0 && num2%2 != 0 ) { 
                     Console.WriteLine("Ambos numeros no son pares");
                }else if (num1%2 != 0){ 
                     Console.WriteLine("El primer numero no es par");
                }
                else { 
                     Console.WriteLine("El segundo numero no es par");
                }
            }
            catch (FormatException letra) {
                Console.WriteLine("Ups! Caracter no admitido. La proxima deberias probar con un numero!");
            }
        }
        static void ejercicio5()
        {
            try { 
                int intentos = 5;
                bool salida2 = true;
                bool salir = true;
                int opcion;
                int numJugador = 0;
                int numJugador2 = 0;
                int num;
                while (salir) { 
                    Console.WriteLine("Vamos a jugar a adivinar un numero. Elija el modo de juego: \n1.Jugador VS Maquina\n2.Jugador VS Jugador");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion != 1 && opcion != 2)
                    {
                        Console.WriteLine("Por favor elija una de las opciones propuestas.Pulse cualquier numero para continuar.");
                        opcion = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (opcion == 1)
                    {
                        Random numAleatorio = new Random();
                        num = numAleatorio.Next(1, 21);
                      
                        for(int i = 0; i<5 && numJugador != num; i++)
                        {
                            Console.WriteLine("Introduzca un numero entre 1 y 20(incluidos). Tienes {0} intento/s", intentos -i);
                            numJugador = Convert.ToInt32(Console.ReadLine());
                            if (numJugador == num)
                            {
                                Console.WriteLine("Lo averiguaste!");
                            }
                            else if (i == 4) {
                                Console.WriteLine("GAME OVER!\nIntentos agotados.El numero era {0}", num);
                            }

                        }
                        salir = false;
                    }
                    else {
                        
                   
                        Console.WriteLine("Para esta version vas a tener que buscar un compañero de juego.\nEl tendra que insertar un numero sin que tu lo veas");
                        Console.WriteLine("Jugador 2: Inserte un numero secreto entre 1 y 20");
                        numJugador2 = Convert.ToInt32(Console.ReadLine());
                        if (numJugador2 < 21 && numJugador2 >= 1) {
                            Console.Clear();
                            Console.WriteLine("Bien ahora Jugador 1 tendra que adivinar que numero era.");
                            for (int i = 0; i < 5 && numJugador2 != numJugador; i++) { 
                                Console.WriteLine("Jugador 1: Introduzca un numero entre 1 y 20. Tienes {0} intento/s", intentos-i);
                                numJugador = Convert.ToInt32(Console.ReadLine());
                                if (i == 4) {
                                    Console.WriteLine("GAME OVER!. El numero secreto era {0}", numJugador2);
                                } else if (numJugador2 == numJugador) { 
                                    Console.WriteLine("Correcto!");
                                }
                            }
                        }
                    }
                }  
            }
            catch(FormatException letra) {
                Console.WriteLine("Ups! Caracter no admitido. La proxima deberias probar con un numero!");
            }
        }
        static void ejercicio6() {
            string numero = "";
            int contador7 = 0;
            Console.WriteLine("Vamos a contar las veces que aparece el 7 en un numero.\nIntroduzca un numero");
            numero = Console.ReadLine();
            contador7 = numero.Split('7').Length - 1;
            Console.WriteLine("El 7 aparece {0} veces", contador7);

        }
        static void ejercicio7() {
            try
            {
                int mes = 0;
                int anio= 0;
                int dias = 0;
                Console.WriteLine("Recordemos viejos tiempos.\nVeamos cuantos dias tenia un mes en un año especifico");
                Console.WriteLine("Introduzca el año");
                anio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el numero del mes");
                mes = Convert.ToInt32(Console.ReadLine());
                dias = DateTime.DaysInMonth(anio, mes);
                Console.WriteLine("El mes {0}, del año {1}, tiene {2} dia/s",mes,anio,dias);

            }
            catch (FormatException letra) {
                Console.WriteLine("Ups! Caracter no admitido. La proxima deberias probar con un numero!");
            }
        }
        static void ejercicio8() { 
            int fila = 4;
            int columna = 4;
            Console.WriteLine("Vamos a jugar con el alfil.\n Para ello indique primero el numero de la fila donde va a estar [1-9]");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el numero de columna [1-9] ");
            columna = Convert.ToInt32(Console.ReadLine());
            if (fila < 1 || fila > 9)
            {
                Console.WriteLine("La fila se sale de los valores establecidos");
            }
            else if (columna < 1 || columna > 9)
            {
                Console.WriteLine("La columna se sale de los valores establecidos");
            }
            else
            {
                Console.WriteLine("A continuacion, se le mostrará el alfil y los movimientos que pueda hacer");
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        if ((i - j == fila - columna) || (i + j == fila + columna))//se suma y se resta para hacer las dos verticales 
                        {
                            Console.Write("* ");
                        }
                        else if ((i + j) % 2 == 0)
                        {
                            Console.Write(" B ");
                        }
                        else if ((i + j) % 2 != 0)
                        {
                            Console.Write(" N ");
                        }

                    }
                    Console.WriteLine();
                }
            }

        }
        static void ejercicio9()
        {
            try
            {
                bool salida9 = true;
                double divisor = 0;
                double dividendo = 0;
                double cociente = 0;
                Console.WriteLine("Vamos a probar a hacer la division de dos numeros. Introduce el divisor ");
                while (salida9) {
                    divisor = Convert.ToInt32(Console.ReadLine());
                    if (divisor != 0)
                    {
                        salida9 = false;

                    }
                    else {
                        Console.WriteLine("El divisor no puede ser 0.Inserte otro numero");
                    }
                }
                Console.WriteLine("Introduzca un numero entero para el dividendo");
                dividendo = Convert.ToInt32(Console.ReadLine());
                cociente = dividendo / divisor;
                Console.WriteLine("El cociente de la division de {0} entre {1} es de " + cociente, dividendo, divisor);
            }
            catch (OverflowException numeroGrande)
            {
                Console.WriteLine("El numero introducido excede el tamaño previsto.\nVuelva a intentarlo mas tarde");
            }
            catch (FormatException letra) {
                Console.WriteLine("Ups! Caracter no admitido. La proxima deberias probar con un numero!");
            }
        }
            public static void Main(string[] args)
        {

            bool salir = false;

            while (!salir)
            {

                try
                {
                    Console.WriteLine("0. Salir");
                    Console.WriteLine("1. Saluda");
                    Console.WriteLine("2. Operaciones");
                    Console.WriteLine("3. Comparar numeros");
                    Console.WriteLine("4. Pares o Impares");
                    Console.WriteLine("5. Adivino");
                    Console.WriteLine("6. Busca a Wally");
                    Console.WriteLine("7. Fechas");
                    Console.WriteLine("8. Ajedrez");
                    Console.WriteLine("9. Division");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());//mejora de hacer la opcion de caracter ya que no tenemos numeros
                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Has elegido salir de la aplicacion");
                            salir = true;
                            break;
                        case 1:
                            Console.WriteLine("Has elegido la opcion 1");
                            ejercicio1();
                            break;

                        case 2:
                            Console.WriteLine("Has elegido la opcion 2");
                            ejercicio2();
                            break;

                        case 3:
                            Console.WriteLine("Has elegido la opcion 3");
                            ejercicio3();
                            break;
                        case 4:
                            Console.WriteLine("Has elegido la opcion 4");
                            ejercicio4();
                            break;
                        case 5:
                            Console.WriteLine("Has elegido la opcion 5");
                            ejercicio5();
                            break;
                        case 6:
                            Console.WriteLine("Has elegido la opcion 6");
                            ejercicio6();
                            break;
                        case 7:
                            Console.WriteLine("Has elegido la opcion 7");
                            ejercicio7();
                            break;
                        case 8:
                            Console.WriteLine("Has elegido la opcion 8");
                            ejercicio8();
                            break;
                        case 9:
                            Console.WriteLine("Has elegido la opcion 9");
                            ejercicio9();
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 0 y 9");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }
    }
}
