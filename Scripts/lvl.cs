using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Q1");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");

    }

}
