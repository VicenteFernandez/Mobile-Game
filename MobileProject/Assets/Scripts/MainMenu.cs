using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class MainMenu : MonoBehaviour {
    public GameObject MainMenuCanvas;
    public GameObject DifficultySelectionCanvas;
	// Use this for initialization
	void Start () {
        DifficultySelectionCanvas.GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (CrossPlatformInputManager.GetButtonDown("Play"))
        {
            Play();
        }
        if (CrossPlatformInputManager.GetButtonDown("Difficulty"))
        {
            Difficulty();
        }
        if (CrossPlatformInputManager.GetButtonDown("Back"))
        {
            Back();
        }
    }
    public void Play()
    {
        SceneManager.LoadScene("Level1");
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
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }
}
