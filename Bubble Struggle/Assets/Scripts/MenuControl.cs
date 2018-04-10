using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour {

	public void Play()
	{
		//retrieves the next scene in queue which in this case is MainScene
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Quit()
	{
		Debug.Log ("Game Has Closed");
		Application.Quit();
	}

	public void PlayAgain()
	{
		//retrieves the previous scene in queue which in this case is MainScene
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void Home()
	{
		//retrieves the first scene in queue which in this case is StartScreen
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 2);
	}

	public void WinAgain()
	{
		//retrieves the screen before Game Over in queue which in this case is MainScene
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 2);
	}

	public void CongratulationsHome()
	{
		//retrieves the screen before Game Over in queue which in this case is MainScene
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 3);
	}

}
