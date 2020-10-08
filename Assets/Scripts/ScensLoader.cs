using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScensLoader : MonoBehaviour
{
    public void LoadNextScene(int nextIndex)
    {
        SceneManager.LoadScene(nextIndex); //  свойство загрузки сцен
       
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
