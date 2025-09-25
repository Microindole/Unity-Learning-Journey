using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 点鼠标左键后，开始定时器
        if(Input.GetMouseButtonDown(0))
        {
            // 自己根据实际需要，实现自己的逻辑

            // IsInvoking 判断是否已经在调度队列中
            // CancelInvoke 从调度队列中移除
            // InvokeRepeating 添加一个新的调度到队列中
            if ( IsInvoking("Expand"))
            {
                CancelInvoke("Expand");
            }
            else
            {
                InvokeRepeating("Expand", 1, 1);
            }
        }
    }

    private void Expand()
    {
        Debug.Log("* 变长 。。" + Time.time);

        Vector3 scale = this.transform.localScale;
        scale.y += 1;
        this.transform.localScale = scale;
    }
}
