using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** �����˶��Ľű�
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
        float rotateSpeed = 10; // ���ٶȣ�ÿ��ת��60�Ƚ�

        this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }
}
