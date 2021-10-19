using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject beam;
    public float shootSpeed;
    public float dist;

    private float timeBtwBeams;
    public float startTimeBtwBeams;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwBeams = startTimeBtwBeams;
    }

    // Update is called once per frame
    void Update()
    {
        //mouse position: get from the world, not from the screen
        Vector3 mPos = Input.mousePosition;
        mPos = Camera.main.ScreenToWorldPoint(mPos);

        //check for rotate self function every frame using mPos
        RotateSelf(mPos);
    }

    //fixed update: tied to the physics engine. Runs at the same rate as the physics engine (physics independent from frame rate)
    //raycasting uses physics, so we will code it under here:
    private void FixedUpdate()
    {
        //if (starting spot of the array, so the player. this is transform.pos. Then, array goes right)
        //raycasts only need a starting position and a direction,
        //but using dist will not make it infinity. It'll make the ray a certain length. Assign this value in Inspector!
        if (timeBtwBeams <= 0)
        {
            if (Physics2D.Raycast(transform.position, transform.right, dist))
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    GameObject newBeam = Instantiate(beam, transform.position, transform.rotation);
                    //set beam's location to the player's location
                    newBeam.transform.position = transform.position;
                    //force for the beam
                    newBeam.GetComponent<Rigidbody2D>().velocity = Vector2.right * shootSpeed;

                    //create beam based on the direction player mouse (face) is next to
                    newBeam.GetComponent<Rigidbody2D>().velocity = transform.right * shootSpeed;

                    timeBtwBeams = startTimeBtwBeams;
                }
            }
        }
        else
        {
            timeBtwBeams -= Time.deltaTime;
        }
    }

    //private void: other scripts cannot access. public void: other scripts can access
    //function takes one parameter: a mouse Position
    void RotateSelf(Vector3 mousePos)
    {
        //vectors can be directions as well, not just points/positinos
        //subtracting positions to change directions
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        //direction face is pointing: 2d uses transform.right for this
        transform.right = direction;
    }
}
