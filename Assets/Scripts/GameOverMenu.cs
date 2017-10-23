using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {


	public string mainMenu;
	public string restart;


	public void RestartGame(){
		Time.timeScale = 1;
		SceneManager.LoadScene (restart);
	}

	public void ReturnMenu (){
		Time.timeScale = 1;
		SceneManager.LoadScene (mainMenu);
	}
}
