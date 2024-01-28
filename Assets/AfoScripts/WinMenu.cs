using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
  public string creditScene;
  // Start is called before the first frame update
  void Start()
    {
        
    }

  public void Credits()
  {
    SceneManager.LoadScene("Credits");
  }
  public void Restart()
  {
    SceneManager.LoadScene("Level_Horse");
  }
  public void Exit()
  {
    Application.Quit();
  }
}
