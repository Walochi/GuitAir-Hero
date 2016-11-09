using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreRet : MonoBehaviour {

	public KeyCode activateEnter;
	public KeyCode activateEsc;
	public Text Finalscore;
	public Text Rank;
	public Text Hcombo;
	static public int missgreen=0;
	static public int missblue=0;
	static public int missyellow=0;
	static public int missorange=0;


	void Start () {
		Finalscore.text = MoveCollider.thescore + "";
		Hcombo.text = MoveCollider.highestcombo + "";
		if(SpawnNotes.songName == "HeroScene"){
			if (MoveCollider.thescore >= 950) {
				Rank.text = "Rank S";		
			}
			if (MoveCollider.thescore >= 700&& MoveCollider.thescore<=849) {
				Rank.text = "Rank A";		
			}
			if (MoveCollider.thescore >= 450&& MoveCollider.thescore<=599) {
				Rank.text = "Rank B";		
			}
			if (MoveCollider.thescore >= 250&& MoveCollider.thescore<=349) {
				Rank.text = "Rank C";		
			}
			if (MoveCollider.thescore > 0 && MoveCollider.thescore<=149) {
				Rank.text = "Rank D";		
			}
		}
		Debug.Log (MoveCollider.thescore);
		if(SpawnNotes.songName == "CloserScene"){
			if (MoveCollider.thescore >= 2300) {
				Rank.text = "Rank S";		
			}
			if (MoveCollider.thescore >= 1900&& MoveCollider.thescore<=2299) {
				Rank.text = "Rank A";		
			}
			if (MoveCollider.thescore >= 1400&& MoveCollider.thescore<=1899) {
				Rank.text = "Rank B";		
			}
			if (MoveCollider.thescore >= 850&& MoveCollider.thescore<=1399) {
				Rank.text = "Rank C";		
			}
			if (MoveCollider.thescore > 400 && MoveCollider.thescore <= 849) {
				Rank.text = "Rank D";		
			}
		}
		if(SpawnNotes.songName == "PokemonScene"){
			if (MoveCollider.thescore >= 1700) {
				Rank.text = "Rank S";		
			}
			if (MoveCollider.thescore >= 1300&& MoveCollider.thescore<=1699) {
				Rank.text = "Rank A";		
			}
			if (MoveCollider.thescore >= 800&& MoveCollider.thescore<=1299) {
				Rank.text = "Rank B";		
			}
			if (MoveCollider.thescore >= 200&& MoveCollider.thescore<=799) {
				Rank.text = "Rank C";		
			}
			if (MoveCollider.thescore > 0 && MoveCollider.thescore <= 199) {
				Rank.text = "Rank D";		
			}
		}
		Debug.Log ("Number of Missed notes: green:" + missgreen + ", blue:" + missblue + ", orange:" + missorange + ", yellow:" + missyellow);

		Debug.Log (SpawnNotes.songName);
		if (MoveCollider.thescore == 0) {
			Rank.text = "Rank F";
		}
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
