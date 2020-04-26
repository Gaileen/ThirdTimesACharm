using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Play()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
