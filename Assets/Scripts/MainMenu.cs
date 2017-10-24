using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string startLevel;
	public string info;

	void Start () {
		Time.timeScale = 1;
	}

	public void NewGame(){
		SceneManager.LoadScene (startLevel);
		Time.timeScale = 1;
	}

	public void moreInfo(){
		SceneManager.LoadScene (info);
		Time.timeScale = 1;
	}

	public void back(){
		SceneManager.LoadScene ("mainMenu");
		Time.timeScale = 1;
	}

	public void authorNote(){
		SceneManager.LoadScene ("authorNote");
		Time.timeScale = 1;
	}

	public void creditView(){
		SceneManager.LoadScene ("credits");
		Time.timeScale = 1;
	}

	public void QuitGame (){
		Application.Quit();
	}
}
