using UnityEngine;
using System.Collections;

public class MovimientoCamara : MonoBehaviour {

	public float velocidad = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float movX = 0f;
		float movZ = 0f;

		if(Input.GetKey(KeyCode.A))
			movX -= velocidad;
		if(Input.GetKey(KeyCode.S))
			movZ -= velocidad;
		if(Input.GetKey(KeyCode.D))
			movX += velocidad;
		if(Input.GetKey(KeyCode.W))
			movZ += velocidad;

		/*Vector3 temp = this.transform.localPosition;
		temp.x += movX;
		temp.z += movZ;
		this.transform.position = temp;*/
		this.transform.Translate (new Vector3 (movX,0f,movZ));

	}
}
