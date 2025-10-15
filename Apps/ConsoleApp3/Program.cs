// 생성자
using System;
using ConsoleApp3;
class MainClass
{
    public static void Main(string[] args)
    {
        // 매개변수의 입력값에 따라 생성자가 호출된다.

        // 1. Cat 생성자 연습
        Console.WriteLine("======== Cat 생성자 연습");
        Cat nabi = new Cat("나비");
        Cat cc = new Cat("냥이", 5);

        // 2. Robot 상속 연습 
        /*
        * Cleanrobot 클래스에는 Move 메소드가 없지만 로봇 클래스를 상속받았기 때문에 호출하더라도 동작한다.  
        */
        Console.WriteLine("======== Robot 상속 연습");
        CleanRobot cleanrobot = new CleanRobot();
        DanceRobot dance = new DanceRobot();
        cleanrobot.Move();
        cleanrobot.Clean();
        dance.Dance();
        dance.Move();

        // 3. getter / setter 연습
        Console.WriteLine("======== getter/setter 연습");
        Dog dog = new Dog();
        dog.setName("잔디");
        Console.WriteLine("강아지의 이름은 " + dog.getName()+ "입니다.");
    }
}
