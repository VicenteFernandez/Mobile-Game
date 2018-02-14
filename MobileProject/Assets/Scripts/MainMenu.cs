using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject MainMenuCanvas;
    public GameObject DifficultySelectionCanvas;
	// Use this for initialization
	void Start () {
        DifficultySelectionCanvas.GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Play()
    {
        SceneManager.LoadScene("Ethan");
    }
    public void Difficulty()
    {
        MainMenuCanvas.GetComponent<Canvas>().enabled = false;
        DifficultySelectionCanvas.GetComponent<Canvas>().enabled = true;

    }
    public void Back()
    {
        MainMenuCanvas.GetComponent<Canvas>().enabled = true;
        DifficultySelectionCanvas.GetComponent<Canvas>().enabled = false;
    }
}
