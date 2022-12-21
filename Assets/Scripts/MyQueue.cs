using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyQueue
{
    public int Count; // 프로퍼티로 만든다

    int[] q;

    int size;

    int rear;
    int front;


    public void Init(int count)
    {
        q = new int[count];

        size = count;

        rear =  0;
        front = 0;
    }


    public void Enqueue(int num)
    {
        // 데이터가 가득 찼는지 체크해 줄 것이다.
        if(rear + 1 % size == front)
        {
            Debug.LogError("Queue가 가득 찼습니다");
            return;
        }
        //리어가 사이즈 끝에 도달했을 때 0으로 
        rear = (rear + 1) % size;
        q[rear] = num;

        Count++;
    }

    public int Dequeue()
    {
        // 데이터가 비어있는지 체크
        if(rear == front)
        {
            Debug.LogError("Queue의 데이터가 없습니다!!");
            return 0;
        }

        front = (front + 1) % size;

        int ret = q[front];
        q[front] = 0;

        Count--;

        //숫자같은 경우에는 리턴을 
        return ret;
    }

    // 알고리즘을 공부하면서 알고리즘의 어떤 로직이 들어갔는지 알고 이해하는 것이다
    // 로직이 어떻게 연결되는지 복습하자
    // 큐로 구현을 할 거라면 프로퍼티를 꼭 써야 한다
}
