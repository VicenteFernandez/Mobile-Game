using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {
     public int HP = 1;
    public string deathScene;
    public AudioClip deathSound;
    float timer = 0;
    bool ded = false, playedSound = false;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		if(HP <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().mass = 10000;
            ded = true;
            
            timer += Time.deltaTime;
            if(timer >= 1)
            {
                SceneManager.LoadScene(deathScene);
            }
        }
        if(ded == true && playedSound == false)
        {
            playedSound = true;
            GetComponent<AudioSource>().clip = deathSound;
            GetComponent<AudioSource>().Play();
        }
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            HP -= 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == 9)
        {
            HP = 0;
        }
    }
   
}
