﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {
    //attach this script to both Canvases
    public GameObject pauseCanvas;
    public GameObject notPausedCanvas;
    public string currentLevel;
	// Use this for initialization
	void Start () {
        pauseCanvas.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseCanvas.GetComponent<Canvas>().enabled = true;
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.GetComponent<Canvas>().enabled = false;
    }
    public void Restart()
    {
        
        SceneManager.LoadScene(currentLevel);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}