using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public void loadLevel(string scene){
		SceneManager.LoadScene (scene);
	}

	public void exit(){
		Application.Quit();
	}
}
