using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {


    public float enemySpeedMin = 0f;
    public float enemySpeedMax = 3f;

    private float enemySpeed;
    private NavMeshAgent enemy;
    private GameObject MainChar;

    // Use this for initialization
    void Start () {
        enemy = GetComponent<NavMeshAgent>();
        MainChar = GameObject.Find("MainChar");
        enemySpeed = Random.Range(enemySpeedMin, enemySpeedMax);

        if (enemy != null)
        {
            enemy.speed = enemySpeed;
          //  enemy.destination = MainChar.transform.position;
        }
    }
	
	// Update is called once per frame
	void Update () {
        enemy.destination = MainChar.transform.position;
    }


}
