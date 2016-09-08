using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyNote : MonoBehaviour {
    public Text failprompt;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.tag=="Note"){
			
			Destroy (other.gameObject);
			Debug.Log ("object destroyed:Fail");
            failprompt.text = "FAIL";
            StartCoroutine(updateText());
            

        }
		else{
			Debug.Log (other.gameObject.tag);
			
		}
	}
    IEnumerator updateText()
    {
        
        yield return new WaitForSeconds(0.5f);
        failprompt.text = "";

    }
}	