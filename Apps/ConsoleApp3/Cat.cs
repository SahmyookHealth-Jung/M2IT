using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Cat
    {
        public string Name;
        public int weight;

        public Cat(string name)
        {
            this.Name = name;
            Console.WriteLine("고양이의 이름은 " + name + "입니다.");
        }
        public Cat(string name, int weight)
        {
            this.Name = name;
            this.weight = 0;
            Console.WriteLine("고양이의 이름은 " + name + "입니다.");
            Console.WriteLine("고양이의 무게는 " + weight + "입니다.");
        }
    }
}
