using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLogic : MonoBehaviour
{
    [Tooltip("�ӵ�ʵ��")]
    public GameObject bulletPrefab;
    [Tooltip("�ӵ��ڵ����")]
    public Transform bulletFolder;
    [Tooltip("�ӵ�������")]
    public Transform firePoint;
    [Tooltip("����")]
    public Transform cannon;
    [Tooltip("�ӵ��ٶ�")]
    public float bulletSpeed;
    [Tooltip("�ӵ�����ʱ��")]
    public float bulletLifeTime;
    [Tooltip("�ӵ�������")]
    public float bulletInterval;
    [Tooltip("����ת��")]
    public float rotateSpeed;

    private Vector3 m_eulerAngles;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        StartFire();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            TestFire();
        }
        float delta = rotateSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            if(m_eulerAngles.y > -75)
            {
                m_eulerAngles.y -= delta;
            }
        }if (Input.GetKey(KeyCode.D))
        {
            if (m_eulerAngles.y < 75)
            {
                m_eulerAngles.y += delta;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if(m_eulerAngles.x > -60)
            {
                m_eulerAngles.x -= delta;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if(m_eulerAngles.x < 10)
            {
                m_eulerAngles.x += delta;
            }
        }

        cannon.transform.localEulerAngles = m_eulerAngles;
        //if (Input.GetMouseButton(0))
        //{
        //    TestFire();
        //}
    }

    private void TestFire()
    {
        Debug.Log("����һ���ӵ���ʵ��");
        GameObject node = Object.Instantiate(bulletPrefab, bulletFolder);
        node.transform.position = this.firePoint.position;
        node.transform.localEulerAngles = this.cannon.localEulerAngles;
        BulletLogic script = node.GetComponent<BulletLogic>();
        script.speed = this.bulletSpeed;
        script.maxDistance = this.bulletSpeed * this.bulletLifeTime;

    }

    private void StartFire()
    {
        if (!IsInvoking("TestFire"))
        {
            InvokeRepeating("TestFire", bulletInterval, bulletInterval);
        }
    }

    private void StopFire()
    {
        CancelInvoke("TestFire");
    }
}
