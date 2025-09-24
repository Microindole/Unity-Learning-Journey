using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 此脚本挂在卫星上
 * 
 */
public class MoonLogic : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float rotateSpeed = 60;
        Transform parent = this.transform.parent;

        parent.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }
}
