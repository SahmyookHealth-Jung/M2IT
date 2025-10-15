using System;
using System.Collections;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("======== ArrayList 연습 ");
        ArrayList al = new ArrayList();

        al.Add(1);
        al.Add("안녕");
        al.Add(3.3);
        al.Add(true);

        foreach (var item in al)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        al.Remove("안녕");
        foreach (var item in al)
        {
            Console.WriteLine(item);
        }

        // Queue 클래스 Enqueue - 추가 / Dequeue - 삭제
        Console.WriteLine("======== Queue 연습 ");
        Queue qu = new Queue();

        qu.Enqueue(1);
        qu.Enqueue(2);
        qu.Enqueue(3);

        while (qu.Count > 0) {
            Console.WriteLine(qu.Dequeue());
        }

        // Stack 클래스 push - 추가 / pop - 삭제
        Console.WriteLine("======== Stack 연습 ");
        Stack st = new Stack();
        st.Push(1);
        st.Push(2);

        while (st.Count > 0)
        {
            Console.WriteLine(st.Pop());
        }

        // Hashtable 클래스 
        Console.WriteLine("======== Hashtable 연습 ");
        Hashtable ht = new Hashtable();
        ht["apple"] = "사과";

        Console.WriteLine(ht["apple"]);
    }
}