using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;


        // Quaternion ����Ԫ�飬����ʹ��
        // transform.rotation = 

        // ŷ���ǣ��ٷ��Ƽ�ʹ��
        // transform.localEulerAngles = new Vector3(0, 45, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float rotateSpeed = 60; // ���ٶȣ�ÿ��ת��60�Ƚ�

        //Vector3 angles = this.transform.localEulerAngles;
        //angles.y += rotateSpeed * Time.deltaTime; //0.5f;
        //this.transform.localEulerAngles = angles;

        this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }
}
