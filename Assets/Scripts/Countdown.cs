using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
	public Text countDown;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		int num = int.Parse (countDown.text);
		countDown.text = "" + (num - 1) + "";
	}
}
