using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("나눌 숫자를 입력하세요: ");
        int divider = int.Parse(Console.ReadLine()); // Console.ReadLine의 경우 문자열을 입력받는 것이기 때문에 int.Parse를 사용하여 정수형으로 변환해준다.

        try
        {
            Console.WriteLine(10 / divider);
        }
        /*catch
        {
            Console.WriteLine("0으로 나눌 수 없습니다.");
        }*/
        catch (Exception e)
        {
            Console.WriteLine("예외 상황: " + e.Message);
        }
    }
}