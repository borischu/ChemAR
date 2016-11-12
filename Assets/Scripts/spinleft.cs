using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class spinleft : MonoBehaviour
{
	public bool isRacePressed = false;
	public bool isBrakePressed = false;

	void Start(){
		
	}

	void Update(){
		if (isRacePressed) {
			transform.Rotate(Vector3.up * Time.deltaTime*90);
		}
	}
	public void onPointerDown()
	{
		isRacePressed = true;
	}
	public void onPointerUp()
	{
		isRacePressed = false;
	}
}

