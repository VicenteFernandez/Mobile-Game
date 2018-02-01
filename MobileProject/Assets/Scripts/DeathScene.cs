using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour {
    float timer = 0;
    public float limit = 3;
    public string SceneToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= limit)
        {
            SceneManager.LoadScene(SceneToLoad);
        }
	}
}
