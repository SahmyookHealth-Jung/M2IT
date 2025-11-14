using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // 배열을 초기화하는 첫 번째 방법
        int[] array1 = new int[3];
        array1[0] = 10;
        array1[1] = 20;
        array1[2] = 30;

        // 배열을 초기화하는 두 번째 방법
        int[] array2 = new int[] {1,2,3};

        // 배열을 초기화하는 세 번째 방법
        int[] array3 = {4, 5, 6};

        // 출력
        Console.WriteLine(array1[0]);
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }
        // foreach 문 사용해서 출력
        foreach(int i in array3)
        {
            Console.WriteLine(i);
        }
    }
}