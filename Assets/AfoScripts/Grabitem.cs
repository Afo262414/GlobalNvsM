using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Grabitem : MonoBehaviour
{
    public Canvas PauseMenu;

  public bool Haveobject = false;
  GameObject hijo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Haveobject && Input.GetKeyDown(KeyCode.Q))
    {
      Debug.Log("ño");
      hijo.transform.SetParent(null);
      Haveobject = false;
    }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
  public void OnTriggerStay(Collider other)
  {
    if (Input.GetKeyDown(KeyCode.E))
    {
      if (other.gameObject.tag == "Raton")
      {
        other.gameObject.GetComponent<AnimalsWander>().enabled = false;
        other.gameObject.transform.SetParent(gameObject.transform);
        Haveobject = true;
      }
      else if (other.gameObject.tag == "Gallina")
      {
        other.gameObject.GetComponent<AnimalsWander>().enabled = false;
        Debug.Log("Si");
        other.gameObject.transform.SetParent(gameObject.transform);
        Haveobject = true;
      }
      else if (other.gameObject.tag == "Dinero")
      {
        other.gameObject.transform.SetParent(gameObject.transform);
        Haveobject = true;
      }
      else if (other.gameObject.tag == "Llaves")
      {
        other.gameObject.transform.SetParent(gameObject.transform);
        Haveobject = true;
      }
      else if (other.gameObject.tag == "Pala")
      {
        other.gameObject.transform.SetParent(gameObject.transform);
        Haveobject = true;
      }
      hijo = other.gameObject;
    }
  }
}
