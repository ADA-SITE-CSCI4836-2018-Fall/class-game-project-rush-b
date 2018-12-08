using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainCharAnim : MonoBehaviour {

    public Animator myAnim;
    public bool isRunning = false;
    public bool isThrowing = false;
    public bool paused;

    


    // Use this for initialization
    void Start () {
        myAnim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
        paused = false;
    }
	
	// Update is called once per frame
	void Update () {

        //  if (Input.GetKey(KeyCode.W) && Input.GetMouseButtonDown(0))
        //{
        //  Debug.Log("Run Throw!");
        //}

        if (Input.GetKey(KeyCode.Escape))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Cursor.lockState = CursorLockMode.None;
            if (paused)
            {
                Time.timeScale = 0;
            }
            else if (!paused)
            {
                Time.timeScale = 1;
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            
            myAnim.SetBool("isRunning", true);
        }
        else
        {
            myAnim.SetBool("isRunning", false);
        }
       if (Input.GetMouseButtonDown(0))
        {
            myAnim.SetBool("isThrowing", true);
        }
        else
        {
            myAnim.SetBool("isThrowing", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myAnim.SetBool("isBack", true);
        }
        else
        {
            myAnim.SetBool("isBack", false);
        }

        





    }
}
