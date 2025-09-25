using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����������Y����ת

public class RotateY : MonoBehaviour
{
    [ Tooltip("�����Y����Ľ��ٶ�") ]
    public float rotateSpeed = 30f;

    private void Awake()
    {
        //this.rotateSpeed = 90;
        Debug.Log("**  Awake , rotateSpeed=" + this.rotateSpeed);

        
    }

    // Start is called before the first frame update
    void Start()
    {
        //this.rotateSpeed = 120;
        Debug.Log("**  Start , rotateSpeed=" + this.rotateSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("** �ٶ�=" + this.rotateSpeed);
        this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }
}
