using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody player;
    public float ForwardForce;
    public float sidewaysForce;
    private bool GameHasEnded = false;
    // Start is called before the first frame update
    void Start()
    {
        //ForwardForce = 500f;
        //sidewaysForce = 200f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            player.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            player.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if(transform.position.y < -1 && GameHasEnded == false)
        {
            GameHasEnded = true;
            FindObjectOfType<GameManager>().Restart();
            
        }
    }
}
