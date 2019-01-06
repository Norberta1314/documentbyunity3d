using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform m_Transform;
    private bool doorState = false;
    
    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    
    void Update()
    {
       
    }

    public void OpenDoor()
    {
        m_Transform.Rotate(Vector3.up, 90);
    }

    public void CloseDoor()
    {
        m_Transform.Rotate(Vector3.up, -90);
    }
}
