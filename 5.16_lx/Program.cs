using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._16_lx
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组

            //int[] arry = new int[8];
            //for (int i = 0; i < arry.Length; i++)
            //{
            //    //给数组的每一个元素赋值
            //    arry[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.ReadLine();

            //int[] arr = { 0,1,2,3,4};
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();
            #endregion

            #region 练习

            //第一题
            //string[] arr1 = { "C语言","C#","java" };
            //string[] arr2 = new string[3] { "C语言", "C#", "java" };
            //string[]arr3=new string[] { "C语言", "C#", "java" };


            //第二题
            //int[] arry = { 1,2,3,4,5,6,7,8,9,10};
            //for (int i = 0; i < arry.Length; i++)
            //{
            //    Console.WriteLine(arry[i]);
            //}

            //Console.ReadLine();


            //第三题

            Console.WriteLine("请输入学生的人数：");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] score = new int[k];
            int max = score[0];
            int min = score[0];
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine("请输入第{0}个学生的成绩;", i + 1);
                int cj = Convert.ToInt32(Console.ReadLine());
                score[i] = cj;

                sum += score[i];

                if (score[i] > max)
                {
                    max = score[i];
                }

                if (score[i] < min)
                {
                    min = score[i];
                }
            }
            avg = sum / score.Length;

            Console.WriteLine("最高分为:{0}，最低分为:{1},总分为:{2},平均分为:{3}", max, min, sum, avg);

            Console.ReadLine();
            #endregion


            #region 

            //  int[,] a = { { 1,90}, { 2,82}, { 3,100}, { 4,51}, { 5,60}, { 6,100}, { 7,87} };
            //for (int i = 0; i < 7; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(a[i,j]);
            //    }
            //}

            //foreach (int item in a)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();

            #endregion
        }
    }
}
