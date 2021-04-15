using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float constanta = 25f;
    float minX = -4.4f;
    float maxX=4.4f;
    public float secondsWave = 2f;
    //Vector3 screenBounds;


    void Start()
    {
            StartCoroutine(spawnWave());
        
    }

   
    public void Spawn()
    {
       
        
            float distanseToFirstEnemy = move.S.ballPOsition.z + constanta;

            float enemyRandomZ = Random.Range(distanseToFirstEnemy, distanseToFirstEnemy + 50f);
            float enemyRandomX = Random.Range(minX, maxX);
            GameObject go = Instantiate(enemyPrefab, new Vector3(enemyRandomX, 0f, enemyRandomZ), Quaternion.identity);
        
    }
    
    
    IEnumerator spawnWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(secondsWave);
            Spawn();
        }
    }
}
