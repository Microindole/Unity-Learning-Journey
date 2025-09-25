using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanLogic : MonoBehaviour
{
    // 最大转速
    public float maxRotateSpeed = 720;

    float m_speed = 0; // 当前转速
    bool m_speedUp = false; // true 加速 , false 减速

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AdjustSpeed", 0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        // 点一下，加速。再点一下，减速。
        if(Input.GetMouseButtonDown(0))
        {
            m_speedUp = !m_speedUp;
        }

        // 旋转
        if(m_speed > 0)
        {
            this.transform.Rotate(0, m_speed * Time.deltaTime, 0, Space.Self);
        }
    }

    // 速度调整
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
