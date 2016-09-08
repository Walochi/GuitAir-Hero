using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyNote : MonoBehaviour {
    public Text failprompt;
    public Font failfont;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.tag=="Note"){
            Color thecolor = new Color();
            ColorUtility.TryParseHtmlString("#FF0000FF", out thecolor);
            Destroy (other.gameObject);
			Debug.Log ("object destroyed:Fail");
            failprompt.color = thecolor;
            failprompt.font = failfont;
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