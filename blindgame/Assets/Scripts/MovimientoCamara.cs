using UnityEngine;
using System.Collections;

public class MovimientoCamara : MonoBehaviour {


	public float velocidad = 1f;
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		/*---Inicia codigo de Poncho
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

		//Vector3 temp = this.transform.localPosition;
		//temp.x += movX;
		//temp.z += movZ;
		//this.transform.position = temp;
		this.transform.Translate (new Vector3 (movX,0f,movZ));
		*---Termina codigo de Poncho*/

		if(Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.DownArrow))
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

		Debug.Log (Input.mousePosition.x);


		if (Input.mousePosition.x < 1*Screen.width/4)  {
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		}

		if (Input.mousePosition.x > 3*Screen.width/4) {
						transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
				}


	}
}
