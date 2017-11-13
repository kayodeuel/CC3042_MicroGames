using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    bool jumped = false;

	// Use this for initialization
	void Start () {
        Debug.Log("Game started");
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0))
        {
            TriggerJump();
            
        }
            

    }
    // Triggers character's jump
    void TriggerJump() {

        if (jumped == false)
        {
            Debug.Log("Jumped.");
            GetComponent<Rigidbody2D>().AddForce(transform.up * 500);
            jumped = true;
        }
                
    }
}
