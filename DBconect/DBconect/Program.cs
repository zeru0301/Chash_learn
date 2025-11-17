using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//レベル1：基礎問題（C#）
// C# 基礎
//問題1：クラスとプロパティ

//「Product」というクラスを作り、以下のプロパティを持たせてください。

//int Id

//string Name

//int Price

//そして、Productの情報をコンソールに表示するメソッドを作成してください。

namespace DBconect
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product p = new Product
            {

                //string? inputName = Console.ReadLine();
                Id = 1,
                Name = "ノート",
                Price = 100
            };

       
            p.DisplayInfo();
           
             //【レベル1：C#基礎 問題2】
            //問題2：配列とループ
            //問題

            //整数の配列

            //{ 10, 20, 30, 40, 50 }

            //この配列の

            //合計値（sum）

            //平均値（average）

            //を計算してコンソールに表示してください。
            int Sum = 0;
            int Ave = 0;
            int[] Nums = { 10, 20, 30, 40, 50 };
            for(int i = 0; i < Nums.Length; i++)
                { 
                 Sum += Nums[i]; 
                
            
            }
             Ave = Sum / (Nums.Length);
            Console.WriteLine(Sum);
            Console.WriteLine(Ave);

        }
        
    }
}
