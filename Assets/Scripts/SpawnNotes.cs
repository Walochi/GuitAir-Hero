using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Environment = System.Environment;

public class SpawnNotes : MonoBehaviour
{
	string savedGamesPath;
	public AudioClip song;
	AudioSource SourceSong;

	public GameObject firstNote;
	public GameObject secondNote;
	public GameObject thirdNote;
	public GameObject fourthNote;

	string col1 = "";
	string col2 = "";
	string col3 = "";
	string col4 = "";
	Stack<GameObject> noteStack1 = new Stack<GameObject>();
	Stack<GameObject> noteStack2 = new Stack<GameObject>();
	Stack<GameObject> noteStack3 = new Stack<GameObject>();
	Stack<GameObject> noteStack4 = new Stack<GameObject>();
	int counter = 0;
	float countdown = 0;

	// Use this for initialization
	void Start ()
	{
		savedGamesPath = Application.dataPath+"/../";
		string[] text = System.IO.File.ReadAllLines(savedGamesPath+song.name+".txt");
		SourceSong = GetComponent<AudioSource>();
		SourceSong.PlayDelayed(2);

		col1 += text [0];
		col2 += text [1];
		col3 += text [2];
		col4 += text [3];

		Debug.Log (col1);
		Debug.Log (col2);
		Debug.Log (col3);
		Debug.Log (col4);


        Screen.SetResolution(1280, 720, true);

		while (counter < col1.Length) {

			if (col1 [counter] == '1') {
				GameObject temp = Instantiate (firstNote, new Vector3 (-54.7f, 50f, 1),firstNote.transform.rotation) as GameObject;
				temp.SetActive (false);
				noteStack1.Push(temp);
			}
			if (col2 [counter] == '1') {
				GameObject temp = Instantiate (secondNote, new Vector3 (-46.1f, 50f, 1),secondNote.transform.rotation) as GameObject;
				temp.SetActive (false);
				noteStack2.Push(temp);
			}
			if (col3 [counter] == '1') {
				GameObject temp = Instantiate (thirdNote, new Vector3 (-37.1f, 50f, 1),thirdNote.transform.rotation) as GameObject;
				temp.SetActive (false);
				noteStack3.Push(temp);
			}		
			if (col4 [counter] == '1') {
				GameObject temp = Instantiate (fourthNote, new Vector3 (-28.5f, 50f, 1),fourthNote.transform.rotation) as GameObject;
				temp.SetActive (false);
				noteStack4.Push(temp);
			}
			counter += 1;
		}

		counter = 0;
	}

	// Update is called once per frame
	void Update ()
	{
		if (countdown >= 0) {
			Debug.Log (countdown);
			countdown -= Time.deltaTime;
			
			return;
		} else {

			if (counter < col1.Length) {

				if (col1 [counter] == '1') {
					noteStack1.Pop ().SetActive(true);
				}
				if (col2 [counter] == '1') {
					noteStack2.Pop ().SetActive(true);
				}
				if (col3 [counter] == '1') {
					noteStack3.Pop ().SetActive(true);
				}
				if (col4 [counter] == '1') {
					noteStack4.Pop ().SetActive(true);
				}
				counter += 1;
			}
		}
	}

	IEnumerator attachMovement ()
	{

		while (true) {
			yield return new WaitForSeconds (1f);

			if (counter < col1.Length) {
				
				if (col1 [counter] == 1) {
					noteStack1.Pop ().SetActive(true);
				}
				if (col2 [counter] == 1) {
					noteStack2.Pop ().SetActive(true);
				}
				if (col3 [counter] == 1) {
					noteStack3.Pop ().SetActive(true);
				}
				if (col4 [counter] == 1) {
					noteStack4.Pop ().SetActive(true);
				}
				counter += 1;
			}
		}
	}
}
