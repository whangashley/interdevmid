using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//alexander zotov tutorial

public class SoundManager : MonoBehaviour
{
    public static AudioClip keySound, enemyHit, playerHit, enemyDetection;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        keySound = Resources.Load<AudioClip>("keySound");
        enemyHit = Resources.Load<AudioClip>("veggieKillAudio");
        playerHit = Resources.Load<AudioClip>("playerHurt");
        enemyDetection = Resources.Load<AudioClip>("enemyDetect");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "keySound":
                audioSrc.PlayOneShot(keySound);
                break;
            case "veggieKillAudio":
                audioSrc.PlayOneShot(enemyHit);
                break;
            case "playerHurt":
                audioSrc.PlayOneShot(playerHit);
                break;
            case "enemyDetect":
                audioSrc.PlayOneShot(enemyDetection);
                break;
        }
    }

}
