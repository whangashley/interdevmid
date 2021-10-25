using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAudio : MonoBehaviour
{
    //public AudioSource mySource;

    // Start is called before the first frame update
    void Start()
    {
        //mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //AudioClip newClip = GetComponent<Sound>().mySound;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("play key sound!!!");

        //GetComponent<AudioSource>().Play();

        /*if (collision.gameObject.tag == "key")
        {
            //make keys play audio:
            //get audio clip 

            //loading up sound that will be played
            mySource.clip = newClip;
            //play the clip
            mySource.Play();
        }*/
    }
}