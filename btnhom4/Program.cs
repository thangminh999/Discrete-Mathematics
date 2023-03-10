using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btnhom4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            SinhNhiPhan(nums, "C:\\Users\\Thang\\Desktop\\bt-TRR\\output.txt");
        }
        public static void SinhNhiPhan(int[] nums, string filename)
        {

            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 0; i < (1 << nums.Length); i++)
                {
                    writer.Write("{ ");
                    Console.Write("{ ");
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if ((i & (1 << j)) > 0)
                        {

                            writer.Write(nums[j] + " ");
                            Console.Write(nums[j] + " ");
                        }
                    }

                    writer.WriteLine("}");
                    Console.WriteLine("}");
                }
            }
        }
    }
}
