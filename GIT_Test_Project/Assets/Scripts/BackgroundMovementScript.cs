using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovementScript : MonoBehaviour {

    Material BGmaterial;
    public float xVelocity;
    public Vector2 offset;
	// Use this for initialization
	void Start ()
    {
        offset = new Vector2(xVelocity, 0);
        BGmaterial = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update ()
    {
        BGmaterial.mainTextureOffset += offset * Time.deltaTime;
	}
}
