using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cs_linq
{
    public class LinqShow
    {

        // Define the data source
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Alice", Age = 18 },
            new Student { Id = 2, Name = "Bob",   Age = 20 },
            new Student { Id = 3, Name = "Carol", Age = 19 },
            new Student { Id = 4, Name = "David", Age = 21 },
            new Student { Id = 5, Name = "Grace", Age = 17 },
            new Student { Id = 5, Name = "Jean", Age = 16 }
        };

        List<Score> scores = new List<Score>
       {
            new Score { StudentId = 1, Points = 55 },
            new Score { StudentId = 2, Points = 88 },
            new Score { StudentId = 3, Points = 92 }
        };

        public void show()
        {
            List<Student> list1 = new List<Student>();

            // 使用正常的遍历方式
            foreach (Student student in students)
            {
                if (student.Age < 18)
                {
                    list1.Add(student);
                }
            }

            // 使用自定义的LINQ
            List<Student> stu = students.XLwhere(x => x.Age < 18).ToList();
            foreach (Student student in stu)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Age);
            }

            // 官方LINQ （使用扩展方法）
            var list2 = students.Where(x => x.Age < 18);

            // 官方LINQ （使用表达式）
            var list3 = from s in students
                        where s.Age < 18
                        select s;

            // Case1 : 过滤 + 排序 + 投影
            var adults = from s in students
                         where s.Age > 18
                         orderby s.Age descending
                         select new { s.Id, s.Name };

            Console.WriteLine(adults.ToList());


            // Case2 : 分组统计
            // 按年龄段分组，统计每组人数
            var ageGroups = from s in students
                            group s by s.Age / 10 into g   // 10-19 岁一组，20-29 岁一组……
                            select new
                            {
                                AgeRange = $"{g.Key * 10}-{g.Key * 10 + 9}",
                                Count = g.Count()
                            };
            Console.WriteLine(ageGroups.ToList());


            // Case3 : 连接（join）——假设有另一张成绩表
            var report = from s in students
                         join sc in scores on s.Id equals sc.StudentId
                         where sc.Points >= 60
                         select new
                         {
                             s.Name,
                             sc.Points
                         };
            Console.WriteLine(report.ToList());
        }
    }


    public static class LinqExtend
    {
        // 自定义方法
        public static IEnumerable<TSource> XLwhere<TSource>(this IEnumerable<TSource> resource, Func<TSource, bool> func)
        {
            List<TSource> list = new List<TSource>();

            foreach (TSource source in resource)
            {
                if (func.Invoke(source))
                {
                    list.Add(source);
                }
            }
            return list;
        }

    }
}

