using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LinqTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 5, 7, 1, 3, 9, 10, 4, 2 }; //쏘팅할때 오더바이가 제일 편한 방법

            var profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "전지현", Height = 171 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "톰크루즈", Height = 170 });
            profiles.Add(new Profile() { Name = "주지훈", Height = 192 });


            var profiles1 = from item in profiles
                            orderby item.Height // ascending이 생략된 것 내림차순하고싶으면 descending 넣어주어야 함
                            select new { Name = item.Name, Inch = item.Height * 0.393 }; // 뉴아이템으로 해주고 키를 인치로 바꿔줄 수 있음

            var profiles2 = profiles.Where(p => p.Height < 172)
                .OrderByDescending(p => p.Height)
                .Select(item =>
                new
                {
                    Name = item.Name,
                    Inch = item.Height * 0.393
                });


            Console.WriteLine("전체 프로필 리스트");
            foreach (var item in profiles1)
            {
                Console.WriteLine($"{item.Name} : {item.Inch} inch.");
            }

            /*var newProfiles = new List<Profile>();
            foreach (var item in profiles)
            {
                if (item.Height < 172)
                    newProfiles.Add(item);
            }*/
            //키 큰순으로 정렬작업 --> 3~4줄 코딩 더 필요

            var newProfiles = from item in profiles
                              where item.Height < 172
                              orderby item.Height descending  //키 큰 순으로 정렬, 매우 간편
                              select item;
            // Linq를 사용해서 줄일 수 있음.

            Console.WriteLine("172cm 이하 프로필 리스트");
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm.");
            }

            //

            int maxSize = 100;
            int[] numbers = new int[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                numbers[i] = (i + 1);
            }

            var result = from item in numbers
                         where (item % 10 == 3 || item % 10 == 6 || item % 10 == 9 ||
                                item / 10 == 3 || item / 10 == 6 || item % 10 == 9)
                         select item;

            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }

            // 15.3
            Console.WriteLine();
            InstClass[] arrClass = {
                new InstClass() {Name = "연두반", Scroes = new int[]{99, 80, 70, 24 } },
                new InstClass() {Name = "분홍반", Scroes = new int[]{60, 45, 87, 72 } },
                new InstClass() {Name = "파랑반", Scroes = new int[]{92, 30, 85, 94 } },
                new InstClass() {Name = "노랑반", Scroes = new int[]{90, 88, 0, 17 } },
             };

            var rstClasses = from item in arrClass
                             from score in item.Scroes
                             where score < 60
                             orderby score ascending
                             select new { item.Name, Lowest = score };
            foreach (var item in rstClasses)
            {
                Console.WriteLine($"{item.Name} : {item.Lowest}");

            }

            //groupby
            var listProfiles = from item in profiles
                               group item by item.Height < 172 into g
                               select new{Groupkey = g.Key, Profiles = g};

            foreach (var item in listProfiles)
            {
                Console.WriteLine($" -172cm 미만 : {item.Groupkey}");

                foreach(var sub in item.Profiles)
                {
                    Console.WriteLine($">>> {sub.Name} : {sub.Height}");
                }
            }
        }
    }
}
