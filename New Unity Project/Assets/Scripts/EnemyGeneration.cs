using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float enemyFrecuency;
    private float lastEnemyTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GenerateEnemy();
    }

    private void GenerateEnemy() 
    {
        if(Time.time - lastEnemyTime >= enemyFrecuency) 
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            lastEnemyTime = Time.time;
        }
        

    }
}
