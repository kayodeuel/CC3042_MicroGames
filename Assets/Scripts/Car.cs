using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

       
		
	}

    public void StartCar()
    {
        Vector3 v = gameObject.GetComponent<Rigidbody2D>().velocity;
        v.x = -5.0f;
        gameObject.GetComponent<Rigidbody2D>().velocity = v;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        print("Hey");
    }
}
