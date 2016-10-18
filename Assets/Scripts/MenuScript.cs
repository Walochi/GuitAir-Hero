using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
	public GameObject song1;
	public GameObject song2;
	public GameObject song3;
	public GameObject play;
	public GameObject exitb;


	public void Start(){
		
	}

	public void show(){			
		song1.SetActive (true);		
		song2.SetActive (true);		
		song3.SetActive (true);
		play.SetActive (false);
		exitb.SetActive(false);
	}

	public void loadLevel(string scene){
		Debug.Log (scene);
		SceneManager.LoadScene (scene);
	}

	public void exit(){
		Application.Quit();
	}
}
