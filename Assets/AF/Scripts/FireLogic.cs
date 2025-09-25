using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLogic : MonoBehaviour
{
    [Tooltip("子弹实体")]
    public GameObject bulletPrefab;
    [Tooltip("子弹节点管理")]
    public Transform bulletFolder;
    [Tooltip("子弹出生点")]
    public Transform firePoint;
    [Tooltip("炮塔")]
    public Transform cannon;
    [Tooltip("子弹速度")]
    public float bulletSpeed;
    [Tooltip("子弹飞行时长")]
    public float bulletLifeTime;
    [Tooltip("子弹发射间隔")]
    public float bulletInterval;
    [Tooltip("炮塔转速")]
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
        Debug.Log("创建一个子弹的实例");
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
