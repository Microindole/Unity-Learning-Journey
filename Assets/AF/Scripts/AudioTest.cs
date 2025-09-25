using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class AudioTest : MonoBehaviour
{
    public AudioClip audioSuccess;
    public AudioClip audioFailure;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayAudio();
    }

    private void PlayAudio()
    {
        
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            AudioSource source = GetComponent<AudioSource>();
            source.PlayOneShot(audioSuccess);
        }
        else if(Input.anyKeyDown)
        {
            AudioSource source = GetComponent<AudioSource>();
            source.PlayOneShot(audioFailure);
        }
    }
}
