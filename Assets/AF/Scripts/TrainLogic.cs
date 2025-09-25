using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 控制小火车，朝着目标运动 
 * 
 */

public class TrainLogic : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        // 近似60FPS运行，不需要太快，不然CPU卡
        Application.targetFrameRate = 60;

        // 注意，target 必须在检查器里赋值 !!!
        // 若 targe 未赋值，在控制台里会报告异常 UnassignedReferenceException
        this.transform.LookAt(target.transform);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p1 = this.transform.position;
        Vector3 p2 = target.transform.position;
        Vector3 p = p2 - p1;
        float distance = p.magnitude;

        if( distance > 0.3f )
        {
            float speed = 2;
            float move = speed * Time.deltaTime;
            this.transform.Translate(0, 0, move, Space.Self);
        }
      

        
    }
}
