using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAudio : MonoBehaviour
{
    public static AudioClip keySound;
    public AudioSource mySource;

    // Start is called before the first frame update
    void Start()
    {
        keySound = Resources.Load<AudioClip>("keyAudio");
        mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "player")
        {
            Debug.Log("play key sound!!!");
            mySource.Play();
        }
    }
}