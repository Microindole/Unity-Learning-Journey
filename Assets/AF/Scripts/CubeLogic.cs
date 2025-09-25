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
        // ���������󣬿�ʼ��ʱ��
        if(Input.GetMouseButtonDown(0))
        {
            // �Լ�����ʵ����Ҫ��ʵ���Լ����߼�

            // IsInvoking �ж��Ƿ��Ѿ��ڵ��ȶ�����
            // CancelInvoke �ӵ��ȶ������Ƴ�
            // InvokeRepeating ���һ���µĵ��ȵ�������
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
        Debug.Log("* �䳤 ����" + Time.time);

        Vector3 scale = this.transform.localScale;
        scale.y += 1;
        this.transform.localScale = scale;
    }
}
