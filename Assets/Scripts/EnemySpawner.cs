using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] float waveSpawnTime=5;
   
    [SerializeField] private int enemyCount;
    [SerializeField] private float timeToWait;
    [SerializeField] private bool stopSpawning = false;

   

    //private List<GameObject> listEnemy;

    private void Awake()
    {
       
       
    }

    private void Start()
    {

        //listEnemy = new List<GameObject>(); 
        //if (!stopSpawning)
        //   InvokeRepeating("WaveSpawn",waveSpawnTime, waveSpawnTime);

       
    }

    private void Update()
    {
        GameObject obj = Instantiate(enemy, this.transform.position, Quaternion.identity);
    }

    IEnumerator EnemyDrop()
    {
       
        
        for (int i = 0; i < enemyCount -1; i++)
        {

            GameObject obj = Instantiate(enemy,this.transform.position, Quaternion.identity);
           
          
            yield return new WaitForSeconds(timeToWait); 
        }
    }

    void WaveSpawn()
    {
        StartCoroutine(EnemyDrop());
    }
}
