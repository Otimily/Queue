using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTest : MonoBehaviour
{
    MyQueue Q = new MyQueue();


    void Start()
    {
        Q.Init(5);
        


        Q.Enqueue(10); // 10 ����
        Q.Enqueue(20); // 20 ����
        Q.Enqueue(30); // 30 ����
        Q.Enqueue(40); // 40 ����
        Q.Enqueue(50); // 50 ����



        Q.Dequeue();

    }

    void Update()
    {
        
    }
}
