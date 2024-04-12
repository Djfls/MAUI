using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Xaml.Schema;

namespace WpfApp1
{
    internal class Class2
    {
        public Class2()
        {
            var books = new List<Book> {
                new Book{Title="こころ",Price=400,Pages=378 },
                new Book{Title="こころ",Price=400,Pages=378 },
                new Book{Title="こころ",Price=400,Pages=378 },
                new Book{Title="こころ",Price=400,Pages=378 },
                new Book{Title="こころ",Price=400,Pages=378 },
                new Book{Title="こころ",Price=400,Pages=378 },
                new Book{Title="こころ",Price=400,Pages=378 },
                new Book{Title="こころ",Price=400,Pages=378 },
                new Book{Title="こころ",Price=400,Pages=378 },
            };


            var numbers = Enumerable.Repeat(-1, 20).ToList();
            var strings = Enumerable.Repeat("(unknown)", 20).ToList();
            var array = Enumerable.Range(1, 20).ToArray();
            var numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var average = numbers.Average();
            var average2 = books.Average(x => x.Price);
            var sum = numbers.Sum();
            var totalPrice = books.Sum(x => x.Price);
            var min = numbers2.Where(n => n > 0).Min();
            var pages = books.Max(x => x.Pages);
            foreach (var item in numbers)
            {
                if (item <= 0)
                {
                    continue;
                }
                min = Math.Min(item, min);
            }
            var count = numbers.Count(n => n == 0);
            var cout2 = books.Count(s => s.Title.Contains("こ"));

            var exists = numbers.Any(n => n % 7 == 0);
            var exists2 = books.Any(x => x.Price >= 100);

            var isAllPositive = numbers.All(n => n > 0);
            var is1000orLes = books.All(x => x.Price <= 1000);

            var num1 = new List<int> { 1, 2, 3 };
            var num2 = new List<int> { 1, 2, 3 };
            var equal = num1.SequenceEqual(numbers2);

            var text = "The quick brown for jump over the lazy dog";
            var words = text.Split(' ');
            var word = words.FirstOrDefault(x => x.Length == 4);//★これをつかう（null）

            var index = numbers2.FindIndex(n => n < 0);
            var results1 = numbers.Where(n => n > 0).Take(5);//5こ取り出す 
            var selected1 = books.TakeWhile(x => x.Price < 600);//見つかった時点で列挙は終了する

            var selected2 = numbers2.SkipWhile(n => n >= 0).ToList();//除外

            var words2 = new List<string> { "Microsoft", "Apple", "Google", "Oracle", "Facebook", };

            var lowers = words2.Select(name => name.ToLower()).ToArray();//別のコレクションを生成する
            var strings3 = numbers2.Select(n => n.ToString("0000")).ToArray();
            var titles = books.Select(x => x.Title);

            var numbers3 = new List<int> { 19, 17, 15, 24, 12, 25, 1420, 12, 28, 19, 30, 24 };//重複
            var results3 = numbers3.Distinct().ToList();

            var sorted = books.OrderBy(x => x.Price);
            var sorted2 = books.OrderByDescending(x => x.Price);

            string[] files1 = Directory.GetFiles(@"C:\Temp");
            string[] files2 = Directory.GetFiles(@"C:\Work");
            var allfiles = files1.Concat(files2).ToList();//統合

            var flowerDict = new Dictionary<string, int>()
            {
                ["sunflower"] = 400,
                ["pansy"] = 400,
                ["tulip"] = 400,
                ["rose"] = 400,
                ["dahlia"] = 400,
            };

            var employee = new Dictionary<int, Employee>() {
                { 100,new Employee(100,"simizu")},
                { 112,new Employee(112,"serizawa")},
                { 125,new Employee(125,"iwase")},
            };

            flowerDict["violet"] = 600;
            employee[126] = new Employee(126, "shono");

            flowerDict.Add("violet", 600);
            employee.Add(126, new Employee(126, "shono"));

            int price2 = flowerDict["rose"];
            var employee2 = employee[125];

            var key = "pansy";
            if (flowerDict.ContainsKey(key)) { var price = flowerDict[key]; }

            var result4 = flowerDict.Remove("pansy");

            //KeyValuePair
            foreach (var item in flowerDict)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }

            var average4 = flowerDict.Average(x => x.Value);

            var total = flowerDict.Sum(x => x.Value);

            var items = flowerDict.Where(x => x.Key.Length <= 5);

            foreach (var item in flowerDict.Keys)
            {
                Console.WriteLine("{0}", item);
            }

            //List→Dictionary
            var employees = new List<Employee>();
            var employeeDic = employees.ToDictionary(emp => emp.Id);
            //別のDictionary生成
            var newDict = flowerDict.Where(x => x.Value >= 400).ToDictionary(x => x.Key, x => x.Value);

            var Dic1 = new Dictionary<MonthDay, string>
            {
                { new MonthDay(3,5),"サンゴの日"},
                { new MonthDay(8,4),"はしの日"},
                { new MonthDay(10,3),"登山の日"},
            };

            var md = new MonthDay(8,4);
            var s = Dic1[md];

            

        }

        public class MonthDay
        {
            public MonthDay(int day, int month)
            {
                Day = day;
                Month = month;
            }

            public int Day { get; private set; }
            public int Month { get; private set; }

        }


        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Employee(int n, string name)
            {

                this.Id = n;
                this.Name = name;
            }
        }

        class Book
        {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
    }
}
