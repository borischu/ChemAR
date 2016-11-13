using UnityEngine;
using System.Collections;
using Vuforia;

public class wolframTestScript : MonoBehaviour {

	void Start(){
		string url = "http://api.wolframalpha.com/v2/query?input=pi&appid=H73X4X-KAJ3T8AH3J";
		WWW www = new WWW(url);
		StartCoroutine(WaitForRequest(www));
	}
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.data);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
}
