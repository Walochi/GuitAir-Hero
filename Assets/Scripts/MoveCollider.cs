using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveCollider : MonoBehaviour {
	public KeyCode activateString;
    public KeyCode activateSpace;
    public float xPos;
    public Font sucfont;
	public Text succesprompt;
    public Text score;
	public Text comboprompt;
	static public double thescore = 0;
	static public int highestcombo = 0;
	// Use this for initialization
	void Start () { 

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (activateString)&&Input.GetKeyDown(activateSpace)) {
			onClick ();
		}

	}
	IEnumerator retractCollider(){
	
		yield return new WaitForSeconds (0.1f);
		transform.position=new Vector3(xPos, -47.4f, 1);
        yield return new WaitForSeconds(0.5f);
        succesprompt.text = "";
		comboprompt.text = "";
		//yield return new WaitForSeconds (0.3f);
		//GetComponent<Rigidbody>().velocity=new Vector3(0,0,0);
	}
	void onClick(){

			
			transform.position=new Vector3(xPos, -34.47f, 1);
			

			StartCoroutine (retractCollider());

	}
	void OnTriggerEnter(Collider other){
        Color thecolor = new Color();
        ColorUtility.TryParseHtmlString("#FFB800FF", out thecolor);
		if (other.gameObject.tag == "Note") {
			
			Destroy (other.gameObject);
			Debug.Log ("object destroyed:Success");
			score.text = "" + (double.Parse(score.text) + (10*SpawnNotes.combomulti));
			thescore = double.Parse (score.text);
            succesprompt.color = thecolor;
            succesprompt.font = sucfont;
			succesprompt.text = "GREAT";
			switch (SpawnNotes.combomulti) {
			case 1:
				break;
			case 2:
				comboprompt.text = "Combo x2";
				break;
			case 3:
				comboprompt.text = "Combo x3";
				break;
			case 4:
				comboprompt.text = "Combo x4";
				break;
			}
			SpawnNotes.combocount ++;
			if (highestcombo < SpawnNotes.combocount) {
				highestcombo = SpawnNotes.combocount;
			}
			StartCoroutine (removeText ());

		}
	}
	IEnumerator removeText(){
		yield return new WaitForSeconds(0.5f);
		succesprompt.text = "";
		comboprompt.text = "";
	}

}
