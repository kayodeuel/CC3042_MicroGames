using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour {

    float timerValue = 5f;
    bool timerIsActive = false;
    public Text timerText;

	// Use this for initialization
	void Start () {

        TriggerCountDown();

    }
	
	// Update is called once per frame
	void Update () {

        if (timerIsActive && timerValue > 0f)
        {
            timerValue -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        int intTimerValue = (int)timerValue;
        timerText.text = intTimerValue.ToString();
	}

    public void TriggerCountDown()
    {
        timerIsActive = true;
    }

   

}


