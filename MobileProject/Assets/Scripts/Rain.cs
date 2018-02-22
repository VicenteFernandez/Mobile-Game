using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour {
    public GameObject cat;
    public GameObject dog;
    bool done = false;
    float timer = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (done == true)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {

                done = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && done == false)
        {
            timer = 0;
            done = true;
            Vector3 spawnPos1 = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
            Vector3 spawnPos2 = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
            GameObject Dog = (GameObject)Instantiate(dog, spawnPos1, Quaternion.identity);
            GameObject Cat = (GameObject)Instantiate(cat, spawnPos2, Quaternion.identity);
        }
    }

}
