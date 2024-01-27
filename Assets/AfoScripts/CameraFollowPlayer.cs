using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
  public Transform m_player;
  // Start is called before the first frame update
  void Start()
  {

  }
  // Update is called once per frame
  void FixedUpdate()
  {
    this.transform.position = new Vector3(m_player.position.x, m_player.position.y, this.transform.position.z);
  }
}
