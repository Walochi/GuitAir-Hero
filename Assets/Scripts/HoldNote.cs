using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HoldNote : MonoBehaviour {
	public KeyCode activateString;
	public float xPos;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (activateString)) {
			onClick ();
		}
		if(Input.GetKeyUp(activateString)){
			transform.position=new Vector3(xPos, -47.4f, 1);

		}

	}

	void onClick(){


		transform.position=new Vector3(xPos, -34.47f, 1);


	}
}
