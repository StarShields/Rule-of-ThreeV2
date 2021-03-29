using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject player;

    public PlayerCollision collision;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {


    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        int numCollisions = 0;

        if(collisionInfo.collider.tag == "player")
        {
            if(numCollisions % 3 == 0)
            {
         //       lives++;
            }
        }
    }

}
