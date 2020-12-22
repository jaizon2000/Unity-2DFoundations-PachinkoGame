using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void OnMouseUp()
    {
        RestartGame();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Scenes/PachinkoScene");
        print("Restarted");
    }
}
