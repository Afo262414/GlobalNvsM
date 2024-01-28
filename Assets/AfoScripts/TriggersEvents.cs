using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersEvents : MonoBehaviour
{
  public GameObject palo;
  public GameObject dinero;
  public GameObject llaves;
  public GameObject fuego;
  public GameObject explosion;
  public GameObject Activators;
  public Transform[] waypoints; // Array of waypoints the Whitexican will follow
  public int currentWaypointIndex = 0; // Index of the current waypoint
  public float moveSpeed = 5f; // Speed at which the Whitexican moves
  private void OnTriggerEnter(Collider other)
  {
    // If the tags are valid it activates some particles and move towards a object to the waypointindex
    if (gameObject.tag == "WDinero" && other.tag == "Dinero")
    {
      llaves.SetActive(true);
      // Use Invoke to destroy objects after a delay of 5 seconds
      Invoke("DestroyObjects", 5f);
    }
    // If the tags are valid activate the particles
    else if (gameObject.tag == "WCabaña" && other.tag == "Raton")
    {
      fuego.SetActive(true);
      dinero.SetActive(true);
    }
    // If the tags are vald move towards a object to the waypointindex
    else if (gameObject.tag == "WCoche" && other.tag == "Llaves")
    {
      explosion.SetActive(true);
      // Use Invoke to destroy objects after a delay of 5 seconds
      Invoke("DestroyObjects", 5f);
    }
    // If the tags are vali it will activate the gravity of the object
    else if (gameObject.tag == "Panal" && other.tag == "Pala")
    {
      Destroy(Activators);
      Destroy(gameObject);
    }
    // If the tags are valid activate the movement to another point of the W
    else if (gameObject.tag == "WRio" && other.tag == "Gallina")
    {
      palo.SetActive(true);
      Destroy(Activators);
      Destroy(gameObject);
    }
  }
  void DestroyObjects()
  {
    Destroy(Activators);
    Destroy(gameObject);
  }
}
