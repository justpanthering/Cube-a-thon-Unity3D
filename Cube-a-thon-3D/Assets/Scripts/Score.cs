using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text ScoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        ScoreBoard.text = player.position.z.ToString("0");
    }
}
