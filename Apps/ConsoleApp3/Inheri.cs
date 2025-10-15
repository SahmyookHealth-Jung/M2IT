using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Robot
    {
        public void Move()
        {
            Console.WriteLine("로봇이 움직입니다.");
        }
    }

    class CleanRobot : Robot // C#에서는 : 가 상속을 의미한다.
    {
        public void Clean()
        {
            Console.WriteLine("청소를 시작합니다.");
        }
    }

    class DanceRobot : Robot
    {
        public void Dance()
        {
            Console.WriteLine("로봇이 춤을 춥니다.");
        }
    }
}