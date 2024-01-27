using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitexicansWander : MonoBehaviour
{
  public Transform[] waypoints; // Array of waypoints the Whitexican will follow
  public int currentWaypointIndex = 0; // Index of the current waypoint
  public float moveSpeed = 5f; // Speed at which the Whitexican moves

  // Start is called before the first frame update
  void Start()
  {
    currentWaypointIndex = 0;
  }

  // Update is called once per frame
  void Update()
  {
    // Move towards the current waypoint
    if (currentWaypointIndex < waypoints.Length)
    {
      Vector3 targetPosition = waypoints[currentWaypointIndex].position;
      transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

      // Check if the enemy has reached the current waypoint
      if (transform.position == targetPosition)
      {
        currentWaypointIndex ++;
        if (currentWaypointIndex >= 8)
        {
          currentWaypointIndex = 0;
        }
      }
      // Check if the move speed is lees of 1f to change the waypoint
      if (moveSpeed < 1f)
      {
        currentWaypointIndex ++;
        if (currentWaypointIndex >= 8)
        {
          currentWaypointIndex = 0;
        }
      }
    }
  }
}
