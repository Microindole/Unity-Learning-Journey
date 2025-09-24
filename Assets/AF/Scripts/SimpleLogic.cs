using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;


        // Quaternion 是四元组，不便使用
        // transform.rotation = 

        // 欧拉角，官方推荐使用
        // transform.localEulerAngles = new Vector3(0, 45, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float rotateSpeed = 60; // 角速度，每秒转动60度角

        //Vector3 angles = this.transform.localEulerAngles;
        //angles.y += rotateSpeed * Time.deltaTime; //0.5f;
        //this.transform.localEulerAngles = angles;

        this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }
}
