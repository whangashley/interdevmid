using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    //public float speed;
    public Rigidbody2D myBody;

    [SerializeField] private GameObject WinScreen;

    public int keysFound;
    bool sixKeys = false;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0;
        keysFound = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CheckKeys();

        if (keysFound == 6)
        {
            sixKeys = true;
        }

        if (sixKeys == true)
        {
            WinScreen.SetActive(true);
        }
    }
    
    void CheckKeys()
    {
        //not transform translate - try different movement code: player movement from sound class - adapt to all directions, not just one
        //movetowards
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "key")
        {
            SoundManager.PlaySound("keySound");
            //keySound.Play();
            keysFound++;
            Destroy(collision.gameObject);
        }
        //if player collides with object with enemy tag
        if (collision.gameObject.tag == "enemy")
        {
            SoundManager.PlaySound("playerHurt");
            //destroy player (me = gameObject)
            Destroy(gameObject);
        }
    }

}