﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Snow_Script : MonoBehaviour {


    public float SnowballS = 45f;
    public float SnowballDestroyTime = 3f;

    public GameObject Snowball;
    public Transform Snow_Spawn;

    public Camera cam;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {

            Invoke("Fire", 0.33f);
        }
    }

    void Fire()
    {

        var Snow_ball = Instantiate(Snowball, Snow_Spawn.position, Snow_Spawn.rotation);
        Snow_ball.GetComponent<Rigidbody>().velocity = Snow_ball.transform.forward * SnowballS;

        Destroy(Snow_ball, SnowballDestroyTime);

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100f))
        {
            //Debug.Log(hit.transform.parent.parent);


            if (hit.transform.parent.parent != null)
            {
                Debug.Log("Hitted");

                Invoke("DealyedFunction", 0.33f);

                //FindObjectOfType<AudioManager>().Play("ding");
                Destroy(hit.transform.parent.parent.gameObject);

                //TimeScript.GameTime += 5;
                //Score.scoreValue += 1;
                //Destroy(hit.transform.parent.parent.gameObject);
            }
            

        }

    }

    private void DelayedFunction()
    {
        FindObjectOfType<AudioManager>().Play("ding");
        

        TimeScript.GameTime += 5;
        Score.scoreValue += 1;
        //Destroy(hit.transform.parent.parent.gameObject);

    }
   

    //IEnumerator WaitSpawner()
    //{
    //    yield return new WaitForSeconds(startWait);
    //    while (!stop)
    //    {
    //        randEnemy = Random.Range(0, 1);

    //        Vector3 spawnPosition = new Vector3(Random.Range(-9, 9), 0, Random.Range(-9, 9));
    //        Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 1, 0), gameObject.transform.rotation);
    //        yield return new WaitForSeconds(spawnWait);

    //    }

    //}

}
