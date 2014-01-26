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

		MinYAngle = -60;
		MaxYAngle = 60;
		MinXAngle = -110;
		MaxXAngle = -30;


		//this.gameObject.transform.localRotation = Quaternion.Euler (+MaxYAngle-Input.mousePosition.y/Screen.height*(MaxYAngle-MinYAngle),0,+MaxXAngle-Input.mousePosition.x/Screen.width*(MaxXAngle-MinXAngle));
		this.gameObject.transform.localRotation = Quaternion.Euler (+MaxYAngle-Input.mousePosition.y/Screen.height*(MaxYAngle-MinYAngle),+MaxXAngle+Input.mousePosition.x/Screen.width*(MaxXAngle-MinXAngle),0);

		//Debug.Log (Input.mousePosition);
	}
}
