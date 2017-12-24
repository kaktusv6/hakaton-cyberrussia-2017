using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

	public void StartGame()
	{
		SceneManager.LoadScene(3);
	}

	public void Exit()
	{
		Application.Quit();
	}
	
	public void OpenMainMenu()
	{
		SceneManager.LoadScene(0);
	}
	
	public void OpenInstructionMenu()
    {
    	SceneManager.LoadScene(2);
    }
}
