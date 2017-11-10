using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteToScreenWidth : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    float worldScreenHeight;
    float worldScreenWidth;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
	}
	
	// Update is called once per frame
	void Update () {

        worldScreenHeight = Camera.main.orthographicSize * 2;
        worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector3(worldScreenWidth / spriteRenderer.sprite.bounds.size.x, transform.localScale.y, 1);
		
	}


}
