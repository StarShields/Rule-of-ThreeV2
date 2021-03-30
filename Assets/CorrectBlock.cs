using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectBlock : MonoBehaviour
{
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
        LEVEL01CONTROLLER level
            = other.gameObject.GetComponent<LEVEL01CONTROLLER>();
        playermovement player
              = other.gameObject.GetComponent<playermovement>();
        if (player != null)
        {
            level.IncreaseScore(3);
            Debug.Log("Score!");
        }
    }
}
