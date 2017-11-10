using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    float timerValue = 5f;
    bool timerIsActive = false;
    public Text guiText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (timerIsActive && timerValue > 0f)
        {
            timerValue -= Time.deltaTime;
        }
        int intTimerValue = (int)timerValue;
        guiText.text = intTimerValue.ToString();
	}

    public void TriggerCountDown()
    {
        timerIsActive = true;
    }

   

}


