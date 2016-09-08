using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveCollider : MonoBehaviour {
	public KeyCode activateString;
	public float xPos;
	public Text succesprompt;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (activateString)) {
			onClick ();
		}

	}
	IEnumerator retractCollider(){
	
		yield return new WaitForSeconds (0.1f);
		transform.position=new Vector3(xPos,-51.89f,1);
        yield return new WaitForSeconds(0.5f);
        succesprompt.text = "";
		//yield return new WaitForSeconds (0.3f);
		//GetComponent<Rigidbody>().velocity=new Vector3(0,0,0);
	}
	void onClick(){

			
			transform.position=new Vector3(xPos,-32.5f,1);
			

			StartCoroutine (retractCollider());

	}
	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "Note") {
			
			Destroy (other.gameObject);
			Debug.Log ("object destroyed:Success");
			succesprompt.text = "GREAT";
		}
	}
}
