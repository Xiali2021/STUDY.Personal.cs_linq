namespace cs_linq
{
    internal class Program
    {
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

            // 只有一个元素等于2，返回2
            var result1 = numbers.Single(x => x == 2); // 返回2

            // 没有元素等于5，抛出异常
            // var result2 = numbers.Single(x => x == 5); // InvalidOperationException

            // 有且只有一个元素大于3，返回4
            var result3 = numbers.SingleOrDefault(x => x > 3); // 返回4

            // 没有元素大于5，返回默认值0
            var result4 = numbers.SingleOrDefault(x => x > 5); // 返回0

            // 有多个元素大于1，抛出异常
            // var result5 = numbers.SingleOrDefault(x => x > 1); // InvalidOperationException

            // 取第一个大于2的元素
            var result6 = numbers.First(x => x > 2); // 返回3
            Console.WriteLine(result6);

            // 取第一个大于2的元素，如果没有则返回默认值0
            var result7 = numbers.FirstOrDefault(x => x > 2);
            Console.WriteLine(result7); // 返回3

            // 取最后一个小于4的元素
            var result8 = numbers.Last(x => x < 4); // 返回3  
            Console.WriteLine(result8);

            // 取最后一个小于1的元素，如果没有则返回默认值0
            var result9 = numbers.LastOrDefault(x => x < 1); // 返回0  
            Console.WriteLine(result9);

            // 跳过小于3的元素，返回剩下的元素
            var result10 = numbers.SkipWhile(x => x < 3);
            foreach (var x in result10)
            {
                Console.WriteLine(x); // 输出: 3 和 4 
            }

            // 取出小于3的元素，直到遇到不满足条件的元素为止
            var result11 = numbers.TakeWhile(x => x < 3);
            foreach (var x in result11)
            {
                Console.WriteLine(x); // 输出: 1 和 2
            }

            // Count 
            Console.WriteLine("Count: " + numbers.Count()); // 输出: Count: 4

            // Any
            Console.WriteLine(numbers.Any(x => x > 3)); // 输出: True

            // Sum
            var sum = numbers.Sum();
            Console.WriteLine("Sum: " + sum);

        }
    }
}
