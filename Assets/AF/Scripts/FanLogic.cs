using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanLogic : MonoBehaviour
{
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }

    public void DoRoate()
    {
        Debug.Log("** Ö´ÐÐ ,DoRoate() ");
        rotateSpeed = 180;
    }
}
