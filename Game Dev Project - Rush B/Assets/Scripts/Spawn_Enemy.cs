using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemy : MonoBehaviour {


    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    private int randEnemy;

    // Use this for initialization
    void Start () {
        StartCoroutine(WaitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
	}

    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            randEnemy = Random.Range(0, 1);

            Vector3 spawnPosition = new Vector3 (Random.Range(-9,9), 0,Random.Range(-9,9));
            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 1, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);

        }

    }

}
