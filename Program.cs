namespace cs_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Test extend method use 
            //ExtendMethod extendMethod = new ExtendMethod();
            //extendMethod.show();


            // Test Linq used 
            //LinqShow linqShow = new LinqShow();
            //linqShow.show();

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


            var result6 = numbers.First(x => x > 2); // 返回3
            Console.WriteLine(result6);

            var result7 = numbers.FirstOrDefault(x => x > 2);
            Console.WriteLine(result7); // 返回3

            var result8 = numbers.Last(x => x < 4); // 返回3  
            Console.WriteLine(result8);

            var result9 = numbers.LastOrDefault(x => x < 1); // 返回0  
            Console.WriteLine(result9);


            var result10 = numbers.SkipWhile(x=>x<3);
            foreach (var x in result10)
            {
                Console.WriteLine(x); // output : 3 and 4 
            }

            var result11 = numbers.TakeWhile(x => x < 3);
            foreach (var x in result11)
            {
                Console.WriteLine(x); // output : 1 and 2
            }
        }
    }
}
