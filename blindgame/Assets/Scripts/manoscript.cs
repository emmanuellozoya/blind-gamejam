using UnityEngine;
using System.Collections;

public class manoscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int MinXAngle;
		int MaxXAngle;
		int MinYAngle;
		int MaxYAngle;

		MinYAngle = 40;
		MaxYAngle = 140;
		MinXAngle = 200;
		MaxXAngle = 330;

		this.gameObject.transform.localRotation = Quaternion.Euler (MaxYAngle-Input.mousePosition.y/Screen.height*(MaxYAngle-MinYAngle),0,MaxXAngle-Input.mousePosition.x/Screen.width*(MaxXAngle-MinXAngle));
		Debug.Log (Input.mousePosition);
	}
}
