namespace cs_linq
{
    /// <summary>
    /// 程序主类，演示常用 LINQ 方法的用法。
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 程序入口点，包含对各种 LINQ 扩展方法的示例演示。
        /// </summary>
        /// <param name="args">命令行参数。</param>
        static void Main(string[] args)
        {
            // 测试扩展方法的用法
            //ExtendMethod extendMethod = new ExtendMethod();
            //extendMethod.show();

            // 测试Linq的用法
            //LinqShow linqShow = new LinqShow();
            //linqShow.show();

            // 定义一个整数列表
            var numbers = new List<int> { 1, 2, 3, 4 };

            // Single: 只有一个元素等于2，返回2，否则抛出异常
            var result1 = numbers.Single(x => x == 2); // 返回2

            // Single: 没有元素等于5，抛出异常
            // var result2 = numbers.Single(x => x == 5); // InvalidOperationException

            // SingleOrDefault: 有且只有一个元素大于3，返回4，否则抛出异常
            var result3 = numbers.SingleOrDefault(x => x > 3); // 返回4

            // SingleOrDefault: 没有元素大于5，返回默认值0
            var result4 = numbers.SingleOrDefault(x => x > 5); // 返回0

            // SingleOrDefault: 有多个元素大于1，抛出异常
            // var result5 = numbers.SingleOrDefault(x => x > 1); // InvalidOperationException

            // First: 取第一个大于2的元素，若无则抛出异常
            var result6 = numbers.First(x => x > 2); // 返回3
            Console.WriteLine(result6);

            // FirstOrDefault: 取第一个大于2的元素，若无则返回默认值0
            var result7 = numbers.FirstOrDefault(x => x > 2);
            Console.WriteLine(result7); // 返回3

            // Last: 取最后一个小于4的元素，若无则抛出异常
            var result8 = numbers.Last(x => x < 4); // 返回3  
            Console.WriteLine(result8);

            // LastOrDefault: 取最后一个小于1的元素，若无则返回默认值0
            var result9 = numbers.LastOrDefault(x => x < 1); // 返回0  
            Console.WriteLine(result9);

            // SkipWhile: 跳过小于3的元素，返回剩下的元素
            var result10 = numbers.SkipWhile(x => x < 3);
            foreach (var x in result10)
            {
                Console.WriteLine(x); // 输出: 3 和 4 
            }

            // TakeWhile: 取出小于3的元素，直到遇到不满足条件的元素为止
            var result11 = numbers.TakeWhile(x => x < 3);
            foreach (var x in result11)
            {
                Console.WriteLine(x); // 输出: 1 和 2
            }

            // Count: 统计元素个数
            Console.WriteLine("Count: " + numbers.Count()); // 输出: Count: 4

            // Any: 判断是否存在大于3的元素
            Console.WriteLine(numbers.Any(x => x > 3)); // 输出: True

            // Sum: 求和
            var sum = numbers.Sum();
            Console.WriteLine("Sum: " + sum);

            // Select: 投影，每个元素平方
            var squares = numbers.Select(x => x * x);
            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }

            // SelectMany: 扁平化嵌套集合
            var listOfLists = new List<List<int>>
            {
                new List<int> {1, 2},
                new List<int> {3, 4},
                new List<int> {5, 6}
            };

            var flattened = listOfLists.SelectMany(list => list);
            Console.WriteLine(flattened);

            // Min: 最小值
            var min = numbers.Min();
            Console.WriteLine("Min: " + min);

            // MinBy: 按指定规则取最小值（此处实际取最大值）
            var minBy = numbers.MinBy(x => -x); // 实际上是取最大值
            Console.WriteLine(minBy);

            // Max: 最大值
            var max = numbers.Max();
            Console.WriteLine("Max: " + max);

            // MaxBy: 按指定规则取最大值（此处实际取最小值）
            var maxBy = numbers.MaxBy(x => -x); // 实际上是取最小值
            Console.WriteLine(maxBy);

            // SequenceEqual: 判断两个序列是否相等
            var otherNumbers = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine(numbers.SequenceEqual(otherNumbers)); // 输出: True

            // Range: 生成从1开始的5个连续整数
            var range = Enumerable.Range(1, 5);
            foreach (var num in range)
            {
                Console.WriteLine(num); // 输出: 1, 2, 3, 4, 5
            }

            // Repeat: 重复数字7三次
            var repeated = Enumerable.Repeat(7, 3);
            Console.WriteLine(repeated);

            // OrderByDescending: 降序排列
            var orderedNumbers = numbers.OrderByDescending(x => x);
            Console.WriteLine(orderedNumbers);

            // Reverse: 反转序列
            var reversedNumbers = numbers.ToArray().Reverse();
            foreach (var num in reversedNumbers)
            {
                Console.WriteLine(num);
            }

            // Distinct: 去重
            var distinctNumbers = numbers.Distinct();
            foreach (var num in distinctNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
