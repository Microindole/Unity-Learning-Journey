using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = this.GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown( 0 ))
        //{
        //    PlayMusic();
        //}

    }

    //void PlayMusic()
    //{
        // ��ȡ���
        //AudioSource audio = this.GetComponent<AudioSource>();
        //audio.Play();
        //audio.mute = true;

        //audio.loop = true;

        //if( audio.isPlaying )
        //{
        //    Debug.Log("* ֹͣ����");
        //    audio.Stop();
        //}
        //else
        //{
        //    Debug.Log("* ��ʼ�������� ..");
        //    audio.Play();
        //}
        
        
    //}

}
