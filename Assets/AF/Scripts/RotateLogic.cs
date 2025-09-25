using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLogic : MonoBehaviour
{
    float m_rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, m_rotateSpeed * Time.deltaTime, 0, Space.Self);
    }

    public void DoRotate()
    {
        m_rotateSpeed = 360*3;
    }
    public void DoStop()
    {
        m_rotateSpeed = 0;
    }
}
