using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWallDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 8)
        {
            GetComponentInParent<EnemyMove>().HitWall();
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.layer == 8)
        {
            GetComponentInParent<EnemyMove>().HitWall();
        }
    }
}
