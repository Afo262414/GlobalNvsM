using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersEvents : MonoBehaviour
{
  public GameObject Activators;
  public Transform[] waypoints; // Array of waypoints the Whitexican will follow
  public int currentWaypointIndex = 0; // Index of the current waypoint
  public float moveSpeed = 5f; // Speed at which the Whitexican moves
  private void OnTriggerEnter(Collider other)
  {
    // If the tags are valid it activates some particles and move towards a object to the waypointindex
    if (gameObject.tag == "Dinero" && other.tag == "WDinero")
    {
      currentWaypointIndex = 0;
      Vector3 targetPosition = waypoints[currentWaypointIndex].position;
      transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
      Destroy(Activators);
      Destroy(other.gameObject);
    }
    // If the tags are valid activate the particles
    else if (gameObject.tag == "Raton" && other.tag == "WCabaña")
    {
      Destroy(Activators);
      Destroy(other.gameObject);
    }
    // If the tags are vald move towards a object to the waypointindex
    else if (gameObject.tag == "Llaves" && other.tag == "WCoche")
    {
      currentWaypointIndex = 1;
      Vector3 targetPosition = waypoints[currentWaypointIndex].position;
      transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
      Destroy(Activators);
      Destroy(other.gameObject);
    }
    // If the tags are valid activate the particles of the explsion
    else if (gameObject.tag == "WCoche" && other.tag == "Explosion")
    {

    }
    // If the tags are vali it will activate the gravity of the object
    else if (gameObject.tag == "Palo" && other.tag == "Panal")
    {

    }
  }
}
