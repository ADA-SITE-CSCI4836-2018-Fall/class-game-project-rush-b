using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.AI;



public class MainCharBeh : MonoBehaviour
{

    public float playerSpeed = 10f;
    public float playerSpeedAngular = 150.0f;
    
    
    
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    GameObject character;

    public AudioSource auidoS;
    public bool isSound = false;

    

    // Use this for initialization
    void Start()
    {
        var navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (navMeshAgent != null)
        {
            navMeshAgent.speed = playerSpeed;
            navMeshAgent.angularSpeed = playerSpeedAngular;
        }

    }



    void Update()
    {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeedAngular;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;

        if (z != 0&&isSound==false)
        {
            //auidoS.enabled = true;

           // Debug.Log("++++++++++++++++++");
           // FindObjectOfType<AudioManager>().Play("running");
            //isSound = true;
        }
        else
        {
            //auidoS.enabled = false;
            
           // Debug.Log("-----------------");
           //FindObjectOfType<AudioManager>().Stop("running");
            //isSound = false;
        }


        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        //var md = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        //md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        //smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        //smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        //mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);

        //mouseLook += smoothV;
        //transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        //character.transform.localRotation = Quaternion.AngleAxis(-mouseLook.x, Vector3.up);


    }

   

}