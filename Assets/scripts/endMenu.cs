using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endMenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }
}
