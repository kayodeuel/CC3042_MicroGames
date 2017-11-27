using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour {

    Vector3 mousePosition; 
        
    Vector3 targetPosition;

    AudioSource sound;

    

    // Use this for initialization
    void Start () {

        //Gets the AudioSource component at the start of the scene
        sound = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        //Stores the current mouse position
        mousePosition = Input.mousePosition;
        //Converts the current mouse position to world space and stores it in targetPosition
        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10));
        //Sets the position of the object with this script attached to the targetPosition
        transform.position = targetPosition;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        sound.Play();
        Destroy(other.gameObject);
    }
}
