using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rb;

//    rigidbody.constraints=RigidbodyConstraints.FreezePositionY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void FreezeBall()
    {
        Debug.Log("Ball is freezed!");
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
}