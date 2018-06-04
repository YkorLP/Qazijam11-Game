using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public playerStats stats;
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public GameObject enemy;

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        InvokeRepeating("LowerSpawnTime", spawnTime * 2, spawnTime * 2);
    }

    void Spawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
    
    void LowerSpawnTime ()
    {
        bool canLower = true;
        if (spawnTime <= 0.3f)
        {
            canLower = false;
        }
        if (canLower == true)
        {
            spawnTime -= 0.1f;
        }
        else
        {
            return;
        }
    }

    /*


    public GameObject[] enemies;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn ()
    {
        yield return new WaitForSeconds(15f);
        //Instantiate(enemy, Random.insideUnitSphere * 5 + transform.position, Random.rotation);
        enemies = new GameObject[10];
        for (int i = 0; i < enemies.Length; i++)
        {
            GameObject clone = (GameObject)Instantiate(enemy, Random.insideUnitSphere * 10 + transform.position, Random.rotation);
            enemies[i] = clone;
        }
    }*/
}
