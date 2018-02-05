using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleLauncher : MonoBehaviour {
    public GameObject prefab;
    bool done = false;
    float timer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(done == true)
        {
            timer += Time.deltaTime;
            if (timer >= 2)
            {
               
                done = false;
            }
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && done == false)
        {
            timer = 0;
            done = true;
            Vector3 spawnPos = gameObject.transform.position;
            GameObject Coconut = (GameObject)Instantiate(prefab, spawnPos, Quaternion.identity);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && done == false)
        {
            timer = 0;
            done = true;
            Vector3 spawnPos = gameObject.transform.position;
            GameObject Coconut = (GameObject)Instantiate(prefab, spawnPos, Quaternion.identity);
        }
    }
}
