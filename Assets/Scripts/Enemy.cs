using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float followStopDist;
    public float retreatDist;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //if the distance between the player's position is greater than the follow stop distance,
        if (Vector2.Distance(transform.position, player.position) > followStopDist)
        {
            //enemy moves towards the player's position
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        //if the distance between the player pos is less than the follow stop distance but greater than retreat dist, (close but not too close)
        else if (Vector2.Distance(transform.position, player.position) < followStopDist && Vector2.Distance(transform.position, player.position) > retreatDist)
        {
            //enemy will not move - it will stay where it is (position)
            transform.position = this.transform.position;
        }
        //if the distance between the player's position is less than the retreat dist,
        else if (Vector2.Distance(transform.position, player.position) < retreatDist)
        {
            //enemy will move away
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
    }
}
