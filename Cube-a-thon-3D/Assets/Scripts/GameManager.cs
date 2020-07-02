using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject CompleteLevelUI;
    public void Restart()
    {
        Debug.Log("Game has Ended");

        Invoke("LoadScene", 2f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void levelComplete()
    {
        Debug.Log("Level Won!");
        CompleteLevelUI.SetActive(true);
    }
}
