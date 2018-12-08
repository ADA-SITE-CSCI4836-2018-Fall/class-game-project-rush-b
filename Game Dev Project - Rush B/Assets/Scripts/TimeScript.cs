using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    public static int timeRem;
    public static int GameTime=5;

    public GameObject completeLevelUI;


    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {

        float t = Time.time - startTime;

        int tr = (int)System.Math.Round(t);

        timeRem = GameTime - tr;

        if (timeRem > 0)
        {
            timerText.text = "remaining time: " + timeRem;
        }
        else if(timeRem < 0)
        {

            //Debug.Log("Woooooooooooooooooooooon!!!!!!!!!!!!");
            //LevelComplete();

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Cursor.lockState = CursorLockMode.None;
            //timerText.text = "Your score is " + Score.scoreValue; ;
            //FindObjectOfType<GameObject>();
        }

    }

    //public void LevelComplete()
    //{
    //    completeLevelUI.SetActive(true);
    //}


}
