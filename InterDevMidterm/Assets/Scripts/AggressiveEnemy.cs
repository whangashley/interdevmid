using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggressiveEnemy : MonoBehaviour
{
    public float speed;
    public float aggroRange;


    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < aggroRange)
        {
            FollowPlayer();
        }
        else
        {
            transform.position = this.transform.position;
        }
    }

    void FollowPlayer()
    {
        if (transform.position.x < player.position.x)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (transform.position.x > player.position.x)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.y < player.position.y)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (transform.position.y > player.position.y)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

}
