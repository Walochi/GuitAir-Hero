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

			if (other.gameObject.name.CompareTo ("blue-note (1)(Clone)")==0) {
				ScoreRet.missblue++;
			} else if (other.gameObject.name.CompareTo ("orange-note (1)(Clone)")==0) {
				ScoreRet.missorange++;
			} else if (other.gameObject.name.CompareTo ("green-note (1)(Clone)")==0) {
				ScoreRet.missgreen++;
			} else if (other.gameObject.name.CompareTo ("yellow-note (1)(Clone)")==0) {
				ScoreRet.missyellow++;
			}

            Destroy (other.gameObject);
			Debug.Log ("object destroyed:Fail");
            failprompt.color = thecolor;
            failprompt.font = failfont;
            failprompt.text = "FAIL";
			SpawnNotes.combocount = 0;
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