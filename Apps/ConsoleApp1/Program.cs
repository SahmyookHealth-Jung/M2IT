Console.WriteLine("Hello, World!");
Console.WriteLine("정승우");

int a = 10;
int b = 15;
int c = a + b;
Console.WriteLine(c);

String s = "정승우는 " + c + "살 이다.";
Console.WriteLine(s);

// 반복문 (for)
Console.WriteLine("구구단 출력하기");

for (int i = 2; i<10;  i++)
{
    Console.WriteLine(i + "단부터 출력하겠습니다.");
    for (int j = 1; j<10; j++)
    {
        Console.WriteLine(i + "X" + j + "=" + i*j );
    } 
}

// 입출력 and if문
Console.Write("이름을 입력하세요: ");
string input = Console.ReadLine();
string name = "jungsw";
if (input.Equals(name))
{
    Console.WriteLine("이름이 일치합니다");
}
else
{
    Console.WriteLine("이름이 일치하지 않습니다");
}
