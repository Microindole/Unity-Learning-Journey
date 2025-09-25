using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SimpleLogic : MonoBehaviour
{
    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Thread.CurrentThread.ManagedThreadId
        Debug.Log("* Start , 线程ID=" + Thread.CurrentThread.ManagedThreadId);

        // 循环反复执行
        this.InvokeRepeating("DoSomething", 1, 1); // 反射机制
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("* Update , 线程ID=" + Thread.CurrentThread.ManagedThreadId);

        this.transform.Translate(0, speed * Time.deltaTime, 0, Space.Self);

    }

    private void DoSomething()
    {
        Debug.Log("* DoSomething 。。。。。。。。。。。 线程ID=" + Thread.CurrentThread.ManagedThreadId);


        this.speed = 0 - speed;
    }

}
