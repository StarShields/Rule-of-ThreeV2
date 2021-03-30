using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public float sidwaysForce = 500;

    public Transform LeftTP;
    public Transform RightTP;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidwaysForce * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidwaysForce * Time.deltaTime, 0, 0);
        }
    }

    public void TeleportLeft()
    {
        rb.transform.position = LeftTP.transform.position;
    }

    public void TeleportRight()
    {
        rb.transform.position = RightTP.transform.position;
    }
}
