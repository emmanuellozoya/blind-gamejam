using UnityEngine;
using System.Collections;

public class AnclajeBrazo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.mousePosition.x;
		float y = Screen.height - Input.mousePosition.y;
		//rotacion en y, -30 a 30 //(0:60) -30 //se mueve en eje local x
		float rotacionX = Mathf.Clamp ( (60f/Screen.width)* x*1000f, 0f, 60000f)/1000f-30f;
		//rotacion en x, -40 a 20 //(0:60) -40 //se mueve en eje local y
		float rotacionY = Mathf.Clamp ( (60f/Screen.height)* y*1000f, 0f, 60000f)/1000f-40f;

		this.transform.localRotation = Quaternion.Euler (rotacionY,rotacionX,0f);
	}
}
