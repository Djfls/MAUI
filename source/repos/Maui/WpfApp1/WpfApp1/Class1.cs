using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Class1
    {
        public Class1()
        {
            var numbers = new[] { 5, 6, 3, 2, 1 };
            Predicate<int> judge =
                (int n) =>
                {
                    if (n % 2 == 0) { return true; }
                    else { return false; }
                };
            var count = Count(numbers, judge);
            count = Count(numbers, (int n) => { if (n % 2 == 0) { return true; } else { return false; } });
            count = Count(numbers, (int n) => { return n % 2 == 0; });
            count = Count(numbers, (int n) => n % 2 == 0);
            count = Count(numbers, (n) => n % 2 == 0);
            count = Count(numbers, n => n % 2 == 0);

            var list = new List<string> { "Tokyo", "NewDelhi", "Bangkok", "London", "Paris", "Berlin" };
            var exixts = list.Exists(s => s[0] == 'A');
            var name = list.Find(s => s.Length == 6);
            var index = list.FindIndex(s => s == "Belin");
            var names = list.FindAll(s => s.Length <= 5);
            var removedCount = list.RemoveAll(s => s.Contains("on"));
            list.ForEach(s => Console.WriteLine(s));
            list.ForEach(Console.WriteLine);
            var lowerList = list.ConvertAll(s => s.ToLower());

            IEnumerable<string> query1 = names.Where(s => s.Length <= 5);
            Array.FindAll<int>(numbers, s => s.ToString().Length <= 5);

            var query = names.Where(s => s.Length <= 5).Select(s => s.ToLower());
            var query2 = names.Select(s => s.Length);
            //以下クエリ演算子試す

            var query3 = names.Where(s=>s.Length<=5);
            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }
            //遅延実行
            names[0] = "Osaka";
            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }

            string[] names2 = { "Tokyo", "NewDelhi", "Bangkok", "London", "Paris", "Berlin" }; ;
            var query5 = names2.Where(s => s.Length >= 5).ToArray();
            foreach (var item in query5)
            {
                Console.WriteLine(item);
            }
            //即時実行
            names[0] = "Osaka";
            foreach (var item in query5)
            {
                Console.WriteLine(item);
            }
            //即時実行
            var count1 = names2.Count(s => s.Length >= 5);

            //クエリ構文
            var query6 = from s in names
                         where s.Length >= 5
                         select s.ToUpper();
            //メソッド構文　　★こっちを使う
            query6 = names.Where(s => s.Length >= 5).Select(s=>s.ToUpper());

            //拡張メソッド使用
            var word = "gateman";
            var result = word.Reverse();
            Console.WriteLine(result);
        }

        public int Count(int[] numbers, Predicate<int> judge)
        {
            int count = 0;
            foreach (var item in numbers)
            {
                if (judge(item) == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
    //拡張メソッド
    public static class StringExtentions
    {
        public static string Reverse(this string str)
        {
            if (string.IsNullOrEmpty(str)) 
            {
                return string.Empty;
            }
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
