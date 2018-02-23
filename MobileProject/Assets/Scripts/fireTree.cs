using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireTree : MonoBehaviour {
    public GameObject prefab;
    private bool done = false;
    public float timer;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(done == true)
        {
            timer += Time.deltaTime;
            if(timer >= 10)
            {
                timer = 0;
                done = false;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (done == false)
        {
            done = true;
            Vector3 spawnPos = gameObject.transform.position;
            GameObject Coconut = (GameObject)Instantiate(prefab, spawnPos, Quaternion.identity);

        }

    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (done == false)
        {
            done = true;
            Vector3 spawnPos = gameObject.transform.position;
            GameObject Coconut = (GameObject)Instantiate(prefab, spawnPos, Quaternion.identity);

        }

    }


}
