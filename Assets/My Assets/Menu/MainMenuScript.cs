﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    void Start()
    {
       // Screen.SetResolution(750, 900, false);
    }

    public void PlayClicked()
    {
        SceneManager.LoadScene("Scene1");
        //ControllerScript.setPauseState(false);
    }
    public void QuitClicked()
    {
        Application.Quit();
    }
}
