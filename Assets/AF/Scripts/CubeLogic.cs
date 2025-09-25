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
        // 获取组件
        //AudioSource audio = this.GetComponent<AudioSource>();
        //audio.Play();
        //audio.mute = true;

        //audio.loop = true;

        //if( audio.isPlaying )
        //{
        //    Debug.Log("* 停止播放");
        //    audio.Stop();
        //}
        //else
        //{
        //    Debug.Log("* 开始播放音乐 ..");
        //    audio.Play();
        //}
        
        
    //}

}
