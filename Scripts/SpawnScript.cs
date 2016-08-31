using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

    public float spawnTime = 2;
    public GameObject enemy;
	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("addEnemy", 0, spawnTime);
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void addEnemy()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-5.97f, 5.97f), transform.position.y, 0);
        Instantiate(enemy, spawnPoint, Quaternion.identity);
    }
}
