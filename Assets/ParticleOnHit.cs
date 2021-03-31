using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleOnHit : MonoBehaviour
{
    ParticleSystem confetti;
    // Start is called before the first frame update
    void Start()
    {
        confetti = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
  confetti.Play();
        }
      
    }
}
