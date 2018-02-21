using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
public class PauseMenu : MonoBehaviour {
    //attach this script to both Canvases
    public GameObject pauseCanvas;
    public GameObject notPausedCanvas;
    public string currentLevel;
    float buttonPressed = 0;
	// Use this for initialization
	void Start () {
        pauseCanvas.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        buttonPressed = CrossPlatformInputManager.GetAxis("Fire2");
        if(buttonPressed == 1)
        {
            buttonPressed = 0;
            PauseGame();
        }
        if (buttonPressed == 2)
        {
            
            buttonPressed = 0;
            Resume();
        }
        if (buttonPressed == 3)
        {
            MainMenu();
        }
        if (buttonPressed == 4)
        {
            Restart();
        }
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
