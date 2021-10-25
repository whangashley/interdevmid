using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code based off of GDTitan's youtube tutorials

public class PlayerCollision : MonoBehaviour
{
    public int keysFound;
    public bool sixKeys = false;

    // Start is called before the first frame update
    void Start()
    {
        keysFound = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (keysFound == 1)
        {
            sixKeys = true;
        }

        if (sixKeys == true)
        {
            StateManager.isGameWin = true;
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "enemy")
        {
            StateManager.isGameOver = true;
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "key")
        {
            //SoundManager.PlaySound("keySound");
            //keySound.Play();
            keysFound++;
            Destroy(collision.gameObject);
        }
    }
}
