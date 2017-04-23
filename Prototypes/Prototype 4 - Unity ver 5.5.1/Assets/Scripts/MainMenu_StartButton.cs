using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu_StartButton : MonoBehaviour {

	public void LoadGame()
    {
        SceneManager.LoadScene(1); 
    }
}
