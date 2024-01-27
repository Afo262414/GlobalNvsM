using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrpt_ObjectKey : MonoBehaviour
{
    #region Variables

    //private string m_TagOfSelf;
    private string m_TagOfObject;//Tag of the object you want to interact with
    private float m_TimeForDestroy;//time for the destruction of the objecr
    //private Collider m_SelfTrigger;

    #endregion

    #region Properties

    public string Tag { get { return m_TagOfObject; } set { m_TagOfObject = value; } } //public property to edit the variable
    public float Time { get { return m_TimeForDestroy;  } set { m_TimeForDestroy = value; } }// public property to edit the time for destruction 

    #endregion

    #region MonoBehaviour

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (m_TagOfObject != null) //Checks if the tag of the object is null
        {
            if (m_TagOfObject == other.tag)//Checks if the tags are equals
            {
                GameObject.Destroy(this);//destroys this object
                GameObject.Destroy(other, 2.5f) ;//Destroy the other object in a time;
            }
        }
        else
        {
            Debug.Log("ERROR: Target Tag Missing");
        }
    }

    #endregion
}
