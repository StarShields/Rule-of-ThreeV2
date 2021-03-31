using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public ParticleSystem effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 12f);
   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (tag == "Player");
       // Destroy(this.gameObject, 4f);
        effect.Play();
    }

}
