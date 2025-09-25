using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLogic : MonoBehaviour
{
    public RotateLogic rotateLogic1;
    public RotateLogic rotateLogic2;

    public FlyLogic flyLogic;

    void Start()
    {
        Application.targetFrameRate = 60;

        rotateLogic1.DoRotate();
        rotateLogic2.DoRotate();

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.loop = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            flyLogic.Fly();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            flyLogic.Land();
        }
        else
        {
            flyLogic.stop();
        }
        

    }




}
