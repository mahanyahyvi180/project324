using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp179
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Random();
            var data = new int[10];

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = generator.Next(10, 100);
            }

            Console.WriteLine("Unsorted array:");
            Console.WriteLine(string.Join("", data) + "\n");

            InsertionSort(data);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join("", data) + "\n");

            public static void InsertionSort(int [] values)
            {
                for (var next = 1; next < values.Length; ++next)
                {
                    var insert = values[next];

                    var moveItem = next;

                   while(moveItem>0&&[moveItem-1])
                }
            }
            }
            }
            }
            }
            }
            }
            
            

        }
    }
}
