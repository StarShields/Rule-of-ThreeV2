using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject[] blocks;

    public int lives;

    public playermovement movement;

    public int score;
    public bool streak = false;
    public int scoreIncrease;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if(collisionInfo.collider.tag == "obstacle")
        {
            Debug.Log("We hit an obstacle");
            lives = lives- 1;
            Debug.Log(lives);

            //code for false door
            //int randomIndex = Random.Range(0, spawnPoints.Length);

            streak = false;




            
        }

        if(collisionInfo.collider.tag == "Correct door")
        {
            score = score + 3;

            streak = true;

            if(streak)
            {
            //    score = score + scoreIncrease();
            }

            Debug.Log(score);

        }
        

    }
}
