using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1;
        float distance = speed * Time.deltaTime;

        //Vector3 pos = this.transform.localPosition;
        //pos.z += distance; // 0.005f;
        //this.transform.localPosition = pos;

        this.transform.Translate(distance, 0, distance);
    }
}
