using System;

namespace DDayPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ✨ C# 디데이 플래너 ✨ ===");

            Console.Write("목표 이름을 입력하세요: ");
            string targetName = Console.ReadLine();

            Console.Write("목표 날짜를 입력하세요 (YYYY-MM-DD): ");
            string dateInput = Console.ReadLine();

            if (DateTime.TryParse(dateInput, out DateTime targetDate))
            {
                // 시간 구성 요소를 제거하고 날짜만 비교
                DateTime today = DateTime.Today;
                TimeSpan difference = targetDate - today;
                int dDay = difference.Days;

                Console.WriteLine("\n" + new string('=', 35));

                if (dDay > 0)
                {
                    Console.WriteLine($"🔥 {targetName}까지 D-{dDay}일 남았습니다!");
                    PrintGuidance(dDay);
                }
                else if (dDay == 0)
                {
                    Console.WriteLine($"🎊 드디어 {targetName} 당일입니다! 행운을 빌어요!");
                }
                else
                {
                    Console.WriteLine($"✅ {targetName}이(가) {Math.Abs(dDay)}일 지났습니다.");
                }

                Console.WriteLine(new string('=', 35));
            }
            else
            {
                Console.WriteLine("❌ 날짜 형식이 올바르지 않습니다. (예: 2026-05-30)");
            }

            Console.WriteLine("\n아무 키나 누르면 종료됩니다...");
            Console.ReadKey();
        }

        static void PrintGuidance(int days)
        {
            Console.WriteLine("\n[📅 기간별 맞춤 전략]");

            // 남은 일수에 따른 조건문
            if (days >= 30)
            {
                Console.WriteLine("▷ 장기전: 첫 2주간은 이론과 기초 체력에 집중하세요.");
                Console.WriteLine("▷ 매일 전체 분량의 " + (100.0 / days).ToString("F1") + "%씩 달성하는 것을 목표로 합니다.");
            }
            else if (days >= 7)
            {
                Console.WriteLine("▷ 단기전: 실전 문제 풀이와 취약점 보완에 집중하세요.");
            }
            else
            {
                Console.WriteLine("▷ 초단기전: 새로운 내용보다는 아는 것을 틀리지 않는 연습을 하세요!");
            }
        }
    }
}