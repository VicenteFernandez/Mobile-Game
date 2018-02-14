using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButtons : MonoBehaviour {
    GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Right()
    {
        player.GetComponent<PlayerControler>().moveX = 1;
    }
    public void Left()
    {
        player.GetComponent<PlayerControler>().moveX = -1;
    }
    public void Jump()
    {
        player.GetComponent<PlayerControler>().JumpButton = true;
    }
}
