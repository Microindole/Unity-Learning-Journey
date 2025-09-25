using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** ����С�𳵣�����Ŀ���˶� 
 * 
 */

public class TrainLogic : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        // ����60FPS���У�����Ҫ̫�죬��ȻCPU��
        Application.targetFrameRate = 60;

        // ע�⣬target �����ڼ�����︳ֵ !!!
        // �� targe δ��ֵ���ڿ���̨��ᱨ���쳣 UnassignedReferenceException
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
