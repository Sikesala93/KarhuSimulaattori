using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonMenu()
    {
        SceneManager.LoadScene(0);
        CustomController.QuitToMenu();
        CustomController.Getvertical();
    }
}
