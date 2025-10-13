using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    // private float startDelay = 1.0f;
    // private float spawnInterval = 3.0f;
    
    async void Start()
    {
        StartCoroutine("StartLoop");
        // InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }


    private IEnumerator StartLoop()
    {
        while (true)
        {
            var random = Random.Range(0, 5);
            Debug.Log($"Random value: {random}");
            
            SpawnRandomBall();
            yield return new WaitForSeconds(random);
        }
    }
    
    void SpawnRandomBall()
    {
        int randomIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        
        Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[randomIndex].transform.rotation);
    }
}
