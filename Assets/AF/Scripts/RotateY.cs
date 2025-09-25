using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 让物体绕着Y轴自转

public class RotateY : MonoBehaviour
{
    [ Tooltip("这个是Y轴向的角速度") ]
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
        Debug.Log("** 速度=" + this.rotateSpeed);
        this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }
}
