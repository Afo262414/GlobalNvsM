using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_inicial : MonoBehaviour
{
    public string gameScene;
    public string creditScene;
    public string MainMenuScene;


    public void Jugar()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void Salir()
    {
        //Debug.Log("Salir...");
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene(creditScene);
    }

    public void Return()
    {
        SceneManager.LoadScene(MainMenuScene);
    }

    public void Continue()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

}
