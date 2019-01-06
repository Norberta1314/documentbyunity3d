using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTriggle : MonoBehaviour
{
    private door m_door;
    // Start is called before the first frame update
    void Start()
    {
        m_door = GameObject.Find("doorParent").GetComponent<door>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
//            Debug.Log("进门");
//            Debug.Log(other.gameObject.name);
            m_door.OpenDoor();
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "player")
        {
//            Debug.Log("出门");
//            Debug.Log(other.gameObject.name);
            m_door.CloseDoor();
        }  
    }
}
