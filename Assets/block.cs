﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Destroy(gameObject, 12f);
       // if(transform.position.y < -2f)
       // {
          //  Destroy(gameObject);
        //}
    }

}
