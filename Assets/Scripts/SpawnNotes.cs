using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnNotes : MonoBehaviour
{

	List<float> col1 = new List<float> () { 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 };
	List<float> col2 = new List<float> () { 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0 };
	List<float> col3 = new List<float> () { 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1 };
	List<float> col4 = new List<float> () { 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0 };

	public GameObject firstNote;
	public GameObject secondNote;
	public GameObject thirdNote;
	public GameObject fourthNote;
	Stack<GameObject> noteStack1 = new Stack<GameObject>();
	Stack<GameObject> noteStack2 = new Stack<GameObject>();
	Stack<GameObject> noteStack3 = new Stack<GameObject>();
	Stack<GameObject> noteStack4 = new Stack<GameObject>();
	int counter = 0;

	// Use this for initialization
	void Start ()
	{
        Screen.SetResolution(1280, 720, true);
		while (counter < col1.Count) {
			if (col1 [counter] == 1) {
				GameObject temp = Instantiate (firstNote, new Vector3 (-54.7f, 50f, 1),firstNote.transform.rotation) as GameObject;
				temp.SetActive (false);
				noteStack1.Push(temp);
			}
			if (col2 [counter] == 1) {
				GameObject temp = Instantiate (secondNote, new Vector3 (-46.1f, 50f, 1),secondNote.transform.rotation) as GameObject;
				temp.SetActive (false);
				noteStack2.Push(temp);
			}
			if (col3 [counter] == 1) {
				GameObject temp = Instantiate (thirdNote, new Vector3 (-37.1f, 50f, 1),thirdNote.transform.rotation) as GameObject;
				temp.SetActive (false);
				noteStack3.Push(temp);
			}		
			if (col4 [counter] == 1) {
				GameObject temp = Instantiate (fourthNote, new Vector3 (-28.5f, 50f, 1),fourthNote.transform.rotation) as GameObject;
				temp.SetActive (false);
				noteStack4.Push(temp);
			}
			counter += 1;
		}

		counter = 0;

		StartCoroutine (attachMovement ());
	}

	// Update is called once per frame
	void Update ()
	{

	}

	IEnumerator attachMovement ()
	{

		while (true) {
			yield return new WaitForSeconds (1f);

			if (counter < col1.Count) {
				
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
