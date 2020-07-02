using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Startgame()
    {
        Debug.Log("Started");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
