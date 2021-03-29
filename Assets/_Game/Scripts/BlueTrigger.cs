using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTrigger : MonoBehaviour
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
            Debug.Log("Blue Trigger Active");
            level.AddBlue();
        }
    }
}
