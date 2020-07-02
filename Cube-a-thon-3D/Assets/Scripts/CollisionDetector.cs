using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public PlayerControl player;
    private bool GameHasEnded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle" && GameHasEnded == false)
        {
            player.enabled = false;
            GameHasEnded = true;
            FindObjectOfType<GameManager>().Restart();
        }
            

    }
}
