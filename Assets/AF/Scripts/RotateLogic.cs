using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLogic : MonoBehaviour
{
    public Vector3 rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3֧�ֱ����˷����ο���20��
        this.transform.Rotate(rotateSpeed * Time.deltaTime, Space.Self);
    }
}
