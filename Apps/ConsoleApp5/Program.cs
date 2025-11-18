using System;
using System.Collections;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("======== ArrayList 연습 ");
        
        // ArrayList 클래스
        // 다양한 타입의 요소를 저장 가능
        // add - 추가 remove - 삭제
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
        // 선입선출 구조를 따르는 컬렉션 
        // 먼저 들어온 요청을 먼저 처리해야 하는 상황에 사용된다. 
        Console.WriteLine("======== Queue 연습 ");
        Queue qu = new Queue();

        qu.Enqueue(1);
        qu.Enqueue(2);
        qu.Enqueue(3);

        while (qu.Count > 0) {
            Console.WriteLine(qu.Dequeue());
        }

        // Stack 클래스 push - 추가 / pop - 삭제
        // 후입선출
        // 가장 최근의 작업을 먼저 처리해야 하는 상황이나 호출 순서를 기억해야 할 때 주로 사용된다.
        // ex) 뒤로 가기 기능 구현
        Console.WriteLine("======== Stack 연습 ");
        Stack st = new Stack();
        st.Push(1);
        st.Push(2);

        while (st.Count > 0)
        {
            Console.WriteLine(st.Pop());
        }

        // Hashtable 클래스 
        // key를 사용하여 value 값을 빠르게 검색해야 하는 상황에 사용
        // 실무에서는 Hashtable 대신 제네릭인 Dictionary<TKey, TValue>를 더 많이 사용된다.
        Console.WriteLine("======== Hashtable 연습 ");
        Hashtable ht = new Hashtable();
        ht["apple"] = "사과";

        Console.WriteLine(ht["apple"]);
    }
}