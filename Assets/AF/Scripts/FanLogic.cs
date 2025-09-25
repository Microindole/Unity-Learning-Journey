using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanLogic : MonoBehaviour
{
    // ���ת��
    public float maxRotateSpeed = 720;

    float m_speed = 0; // ��ǰת��
    bool m_speedUp = false; // true ���� , false ����

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AdjustSpeed", 0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        // ��һ�£����١��ٵ�һ�£����١�
        if(Input.GetMouseButtonDown(0))
        {
            m_speedUp = !m_speedUp;
        }

        // ��ת
        if(m_speed > 0)
        {
            this.transform.Rotate(0, m_speed * Time.deltaTime, 0, Space.Self);
        }
    }

    // �ٶȵ���
    private void AdjustSpeed()
    {
        if(m_speedUp)
        {
            if (m_speed < maxRotateSpeed)
                m_speed += 10;
        }
        else
        {
            m_speed -= 10;
            if (m_speed < 0)
                m_speed = 0;
        }
    }

}
