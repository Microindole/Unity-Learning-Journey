using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCubeLogic : MonoBehaviour
{
    [ Tooltip("这是Y轴上的方向")]
    public float rotateSpeed = 60f;
    private void Awake()
    {
        Debug.Log("awake...");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start...");

    }

    // Update is called once per frame
    void Update()
    {
        //float rotateSpeed = 60;
        Debug.Log("speed: " + rotateSpeed);

        this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");

    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
