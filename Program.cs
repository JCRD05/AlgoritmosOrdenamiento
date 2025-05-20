using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeOrdenado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("===== ALGORITMOS DE ORDENAMIENTO =====");
                Console.WriteLine("1. Generar arreglo aleatorio");
                Console.WriteLine("2. Ingresar arreglo manualmente");
                Console.WriteLine("3. Ordenamiento Burbuja Ascendente");
                Console.WriteLine("4. Ordenamiento Burbuja Descendente");
                Console.WriteLine("5. Burbuja Señal (Flagged Bubble)");
                Console.WriteLine("6. Burbuja de Sacudida (Shaker Sort)");
                Console.WriteLine("7. Inserción");
                Console.WriteLine("8. Inserción Binaria");
                Console.WriteLine("9. Selección");
                Console.WriteLine("10. Shell");
                Console.WriteLine("11. QuickSort");
                Console.WriteLine("12. HeapSort");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        array = GenerateRandomArray();
                        Console.WriteLine("Arreglo generado:");
                        Sort.Print(array);
                        break;

                    case 2:
                        Console.Write("Ingresa los elementos separados por espacio: ");
                        string[] input = Console.ReadLine().Split(' ');
                        array = new int[input.Length];
                        for (int i = 0; i < input.Length; i++)
                        {
                            array[i] = Convert.ToInt32(input[i]);
                        }
                        break;

                    case 3:
                        Sort.AscendingBubble(ref array);
                        break;
                    case 4:
                        Sort.DescendingBubble(ref array);
                        break;
                    case 5:
                        Sort.FlaggedBubble(ref array);
                        break;
                    case 6:
                        Sort.Shaker(ref array);
                        break;
                    case 7:
                        Sort.Insertion(ref array);
                        break;
                    case 8:
                        Sort.BinaryInsertion(ref array);
                        break;
                    case 9:
                        Sort.Selection(ref array);
                        break;
                    case 10:
                        Sort.Shell(ref array);
                        break;
                    case 11:
                        Sort.Quick(ref array);
                        break;
                    case 12:
                        Sort.Heap(ref array);
                        break;
                    case 0:
                        exit = true;
                        continue;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (option >= 3 && option <= 12)
                {
                    Console.WriteLine("\nArreglo ordenado:");
                    Sort.Print(array);
                }

                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }
        }

        static int[] GenerateRandomArray()
        {
            Console.Write("¿Cuántos elementos deseas? ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor mínimo: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor máximo: ");
            int max = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int[] result = new int[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = rand.Next(min, max + 1);
            }

            return result;
        }
    }
}
