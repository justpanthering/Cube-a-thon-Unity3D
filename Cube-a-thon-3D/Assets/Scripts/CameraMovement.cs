using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newplayer = new Vector3(player.position.x, 0, player.position.z);
        if (newplayer.x < 5.5 && newplayer.x > -5.5)
            transform.position = newplayer + offset;
        else if(newplayer.x > 5.5)
            transform.position = new Vector3(5.5f, 0, player.position.z) + offset;
        else if (newplayer.x < -5.5)
            transform.position = new Vector3(-5.5f, 0, player.position.z) + offset;
    }
}
