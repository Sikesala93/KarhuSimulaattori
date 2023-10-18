using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene(1);
        CustomController.ButtonStart();
        CustomController.Getvertical();
    }

    public void ButtonQuit()
    {
        Application.Quit();
        CustomController.ButtonQuit();
        CustomController.Getvertical();
    }
}
