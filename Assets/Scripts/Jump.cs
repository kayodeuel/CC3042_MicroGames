using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    bool jumped = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TriggerJump() {

        if (!jumped)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * 500);
            jumped = true;
        }
        
        
    
    }
}
