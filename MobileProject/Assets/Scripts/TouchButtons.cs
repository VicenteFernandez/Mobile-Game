using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchButtons : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Debug.Log("Success");
        }
	}
}
