﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporters : MonoBehaviour
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
        
        if (player != null)
        {
            Debug.Log("TP ACTIVATED");
            player.TeleportRight();
        }
    }
}
