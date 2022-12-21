using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTest : MonoBehaviour
{
    MyQueue Q = new MyQueue();


    void Start()
    {
        Q.Init(5);
        


        Q.Enqueue(10); // 10 »ğÀÔ
        Q.Enqueue(20); // 20 »ğÀÔ
        Q.Enqueue(30); // 30 »ğÀÔ
        Q.Enqueue(40); // 40 »ğÀÔ
        Q.Enqueue(50); // 50 »ğÀÔ



        Q.Dequeue();

    }

    void Update()
    {
        
    }
}
