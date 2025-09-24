using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 地球运动的脚本
 * 
 */
public class PlanetLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateSpeed = 10; // 角速度，每秒转动60度角

        this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }
}
