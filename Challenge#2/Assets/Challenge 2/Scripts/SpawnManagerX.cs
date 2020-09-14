/** John Mordi* 
 * Assignment #3 Challenge #2* 
 * Spawns random ball objects from the top of the screen at random intervals in random positions*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    //public static bool gameOver = false;
    //private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(3,5));
        StartCoroutine(SpawnRandomBallWithCoroutine());
    }

    IEnumerator SpawnRandomBallWithCoroutine()
    {
        while(!StatManager.gameOver)
        {
            float randomTime = Random.Range(3, 5);

            yield return new WaitForSeconds(randomTime);

            SpawnRandomBall();
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int preFabIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[preFabIndex], spawnPos, ballPrefabs[preFabIndex].transform.rotation);
    }

}
