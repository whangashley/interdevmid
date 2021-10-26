using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAudio : MonoBehaviour
{
    public AudioSource mySource;

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "key")
        {
            //Debug.Log("play key sound!!!");
            mySource.Play();
        }
    }
}