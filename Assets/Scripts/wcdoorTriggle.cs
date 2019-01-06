using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wcdoorTriggle : MonoBehaviour
{
    private door m_door;
    // Start is called before the first frame update
    void Start()
    {
        m_door = GameObject.Find("wcdoorParent").GetComponent<door>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            m_door.CloseDoor();
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            m_door.OpenDoor();
        }  
    }
}
