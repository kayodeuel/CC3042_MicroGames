using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Car : MonoBehaviour {

    public float speed = -5.0f;

	// Use this for initialization
	void Start () {
        StartCar();
    }
	
	// Update is called once per frame
	void Update () {

       
		
	}

    public void StartCar()
    {
        Vector3 v = gameObject.GetComponent<Rigidbody2D>().velocity;
        v.x = speed;
        gameObject.GetComponent<Rigidbody2D>().velocity = v;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        
        Destroy(coll.gameObject);
    }


}
