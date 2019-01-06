using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTriggle : MonoBehaviour
{
    private ball m_ball;

    private textscript m_text;
    // Start is called before the first frame update
    void Start()
    {
        m_ball = GameObject.Find("ball").GetComponent<ball>();
        m_text = GameObject.Find("text").GetComponent<textscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
//        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "ball")
        {
            Debug.Log("win!");
            m_ball.FreezeBall();
            m_text.disable();
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
