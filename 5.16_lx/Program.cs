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

            //Console.WriteLine("请输入学生的人数：");
            //int k = Convert.ToInt32(Console.ReadLine());
            //double[] score = new double[k];
            //double max = score[0];
            //double min = score[0];
            //double sum = 0;
            //double avg = 0;
            //for (int i = 0; i < score.Length; i++)
            //{
            //    Console.WriteLine("请输入第{0}个学生的成绩;", i + 1);
            //    int cj = Convert.ToInt32(Console.ReadLine());
            //    score[i] = cj;

            //    sum += score[i];

            //    if (score[i] > max)
            //    {
            //        max = score[i];
            //    }

            //    if (score[i] < min)
            //    {
            //        min = score[i];
            //    }
            //}
            //avg = sum / score.Length;

            //Console.WriteLine("最高分为:{0},最低分为:{1},总分为:{2},平均分为:{3}", max, min, sum, avg);

            //Console.ReadLine();
            #endregion


            #region 

            //int[,] a = { { 1, 90 }, { 2, 82 }, { 3, 100 }, { 4, 51 }, { 5, 60 }, { 6, 100 }, { 7, 87 } };
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //foreach (int item in a)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();

            #endregion

            #region 二位数组

            //int[,] arr = { { 101,102,103,104}, {201,202,203,204}, { 301,302,303,304}, { 401,402,403,404} };
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.Write("第{0}层",i+1);
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(" "+arr[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();


            #endregion

            #region  foreach遍历交错数组
            //int[][] array = new int[2][];
            //array[0] = new int[] { 1, 2 };
            //array[1] = new int[] { 3, 4, 5 };
            //int index = 0;
            //foreach (int[] item in array)
            //{
            //    index++;
            //    Console.Write("第{0}个数组：",index);

            //    foreach (int item1 in item)
            //    {
            //        Console.Write(" "+item1);

            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();
            #endregion


            #region  Clear

            //Clear清空
            //int[] arr = { 1, 2, 3, 4 };
            //Array.Clear(arr,1,2);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            // }
            //  Console.ReadLine();

            //Clone浅复制
            //int[] arr1 = { 1, 2 };
            //int[] arr2 = (int[])arr1.Clone();

            //Array.Copy复制
            //int[] a = { 1, 2, 3 };
            //int[] b = new int[a.Length];
            //Array.Copy(a, 0, b, 0, a.Length);

            //CopyTo
            //int[] a = { 1, 2, 3, };
            //int[] n = new int[a.Length];
            //n.CopyTo(a,0);

            //Reverse() 反转

            //int[] a = new int []{ 1, 2, 3 };
            //Array.Reverse(a);




          
            #endregion
        }
    }
}
