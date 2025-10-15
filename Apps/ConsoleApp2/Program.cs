// 객체 지향 프로그래밍
// Main 메소드는 C# 코드를 실행할 때 가장 먼저 수행되는 부분입니다. 따라서 Main 메소드는 반드시 구현해야합니다.
/*
 * 사람, 동물, 식물, 사물 등을 모두 클래스로 표현할 수 있고, 이들을 표현하기 위해 단순화하는 작업을 추상화(Abstract)라고 부릅니다.
 * EX) 사람의 정적인 특징인 이름, 생년월일, 성별 등은 속성으로 선언 / 먹다, 뛰다 등의 동적인 특징은 메소드로 선언
 */

class Person {
    //속성(Property)
    public string Name;
    public String Birthday;
    public string Gender;

    //메소드(Method)
    public void Eat()
    {
        // 먹는 행위
        Console.WriteLine(Name + "(이)가 아침을 먹습니다.");
    }

    public void Walk()
    {
        // 걷는 행위
        Console.WriteLine(Name + "(이)가 한강을 걷습니다.");
    }
    public void Run()
    {
        // 뛰는 행위
        Console.WriteLine(Name + "(이)가 한강을 뜁니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Person p1,p2;
        p1 = new Person();
        p2 = new Person();
        p1.Name = "승우";
        p2.Name = "동현";
        p1.Eat();
        p1.Walk();
        p2.Run();
    }
}