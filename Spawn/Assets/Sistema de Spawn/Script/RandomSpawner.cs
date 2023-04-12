using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] Obj;
    public GameObject UltimoObjeto;
    public float SpawnTimer = 1;
    public float RateSpawn = 3;
    public float contador;
    public float time;
    

    public void Start()
    {
        InvokeRepeating("Spawnn", SpawnTimer, RateSpawn);
    }
    // Update is called once per frame
    void Spawnn()
    {
        
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
           UltimoObjeto = Instantiate(Obj[Random.Range(0,Obj.Length)], randomSpawnPosition, Quaternion.identity);

        contador = contador + 1;
        Debug.Log(contador);
       
        time = RateSpawn;
        time -= Time.deltaTime;
        
    }
}
