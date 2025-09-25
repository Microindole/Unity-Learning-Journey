using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBox : MonoBehaviour
{

    public AudioClip[] songs;
    // Start is called before the first frame update
    void Start()
    {
        if (songs == null || songs.Length == 0)
        {
            Debug.Log("Please check your resources!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) NextSong();
    }

    private void NextSong()
    {
        // random play
        int index = Random.Range(0, songs.Length);
        // Random.Range(min, max);
        AudioClip clip = songs[index];
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.volume = int.MaxValue / 2;
        audioSource.clip = clip;
        string num = null;
        switch (index)
        {
            case 0: num = "first";break;
            case 1: num = "second";break;
            case 2: num = "third";break;
            default:num = "null";break;
        }
        Debug.Log("Play the " + num + " song, its name is \"" + clip.name + "\".\nThe volume is half.");
        audioSource.Play();
    }
}
