using UnityEngine;
using System.Collections;
using Environment = System.Environment;

public class CreateNotes : MonoBehaviour {
	string a1 = "";
	string a2 = "";
	string a3 = "";
	string a4 = "";
	public AudioClip song;
	float duration;
	AudioSource a;
	string savedGamesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).Replace("\\","/") + "/My Games/GuitairHero/";
	bool flag = true;
	// Use this for initialization
	void Start () {
		
		a = GetComponent<AudioSource>();
		a.clip = song;
		duration = song.length;
		a.Play();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (a.isPlaying) {
			if (Input.GetKeyDown (KeyCode.A)) {
				a1 += "1";
				Debug.Log ("A added");
			} else {
				a1 += "0";
			}
			if (Input.GetKeyDown (KeyCode.S)) {
				a2 += "1";
				Debug.Log ("S added");

			} else {
				a2 += "0";
			}
			if (Input.GetKeyDown (KeyCode.K)) {
				a3 += "1";
				Debug.Log ("K added");

			} else {
				a3 += "0";
			}
			if (Input.GetKeyDown (KeyCode.L)) {
				a4 += "1";
				Debug.Log ("L added");

			} else {
				a4 += "0";
			}
		} else {
			if (flag) {
				string[] piece = { a1, a2, a3, a4 };
				System.IO.File.WriteAllLines (savedGamesPath + song.name + ".txt", piece);
				Debug.Log (song.name + ".txt successfully created!");
				flag = !flag;
			}
		}
	}




}
