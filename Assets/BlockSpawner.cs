using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;

    public int randomIndex;

    private float timeToSpawn = 2f;

    public float timeBetweenWaves = 120;

    // Start is called before the first frame update
    void Start()
    {
  

        
    }


    void Update()
    {
       if( Time.time >= timeToSpawn)
        {
            SpawnBlocks();

            timeToSpawn = Time.time + 5;


        }
    }

    void SpawnBlocks()
    {
         randomIndex = Random.Range(0, spawnPoints.Length);


        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(door1, spawnPoints[i].position, Quaternion.identity);
            }

            if(randomIndex == i)
            {
                Instantiate(door2, spawnPoints[i].position, Quaternion.identity);
            }
        }

    }
    


}
    // Update is called once per frame
    

