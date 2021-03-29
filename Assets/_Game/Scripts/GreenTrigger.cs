using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTrigger : MonoBehaviour
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
        playermovement player
              = other.gameObject.GetComponent<playermovement>();
        LevelManager level
            = other.gameObject.GetComponent<LevelManager>();

        if (player != null)
        {
            Debug.Log("Green Trigger Active");
            level.AddGreen();
        }
    }
}
