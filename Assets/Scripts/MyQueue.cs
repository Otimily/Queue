using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyQueue
{
    public int Count; // ������Ƽ�� �����

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
        // �����Ͱ� ���� á���� üũ�� �� ���̴�.
        if(rear + 1 % size == front)
        {
            Debug.LogError("Queue�� ���� á���ϴ�");
            return;
        }
        //��� ������ ���� �������� �� 0���� 
        rear = (rear + 1) % size;
        q[rear] = num;

        Count++;
    }

    public int Dequeue()
    {
        // �����Ͱ� ����ִ��� üũ
        if(rear == front)
        {
            Debug.LogError("Queue�� �����Ͱ� �����ϴ�!!");
            return 0;
        }

        front = (front + 1) % size;

        int ret = q[front];
        q[front] = 0;

        Count--;

        //���ڰ��� ��쿡�� ������ 
        return ret;
    }

    // �˰����� �����ϸ鼭 �˰����� � ������ ������ �˰� �����ϴ� ���̴�
    // ������ ��� ����Ǵ��� ��������
    // ť�� ������ �� �Ŷ�� ������Ƽ�� �� ��� �Ѵ�
}
