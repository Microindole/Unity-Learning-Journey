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
        Debug.Log("* Start , �߳�ID=" + Thread.CurrentThread.ManagedThreadId);

        // ѭ������ִ��
        this.InvokeRepeating("DoSomething", 1, 1); // �������
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("* Update , �߳�ID=" + Thread.CurrentThread.ManagedThreadId);

        this.transform.Translate(0, speed * Time.deltaTime, 0, Space.Self);

    }

    private void DoSomething()
    {
        Debug.Log("* DoSomething ���������������������� �߳�ID=" + Thread.CurrentThread.ManagedThreadId);


        this.speed = 0 - speed;
    }

}
