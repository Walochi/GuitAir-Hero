using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreRet : MonoBehaviour {

	public KeyCode activateEnter;
	public KeyCode activateEsc;
	public Text Finalscore;

	void Start () {
		Finalscore.text = MoveCollider.thescore + "";
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (activateEnter)){
			SceneManager.LoadScene ("TitleScreen");
		}
		if (Input.GetKey (activateEsc)){
			SceneManager.LoadScene ("TitleScreen");
		}
		if (Input.GetMouseButtonDown (0)){
			SceneManager.LoadScene ("TitleScreen");
		}
	}
}
