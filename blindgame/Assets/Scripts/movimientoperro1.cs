using UnityEngine;
using System.Collections;

public class movimientoperro1 : MonoBehaviour {
	public float velocidad = 0.33f;
	public GameObject Persona;
	public float DistCorrea = 18.5f;
	public bool PerroGuiando = true;

	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MovPersona ();
		MovPerro ();
	}


	void MovPersona() {
		if (PerroGuiando) { 
						float Dist = 0;
						Vector3 PosPersona = Persona.gameObject.transform.position;
						Vector3 PosPerro = this.gameObject.transform.position;
						PosPerro.y = 0;
						PosPersona.y = 0;

						Dist = Vector3.Distance (PosPerro, PosPersona);
						if (Dist > DistCorrea) {
								Vector3 PosDif = PosPerro - PosPersona; //moverse hacia el perro
								PosDif.Normalize (); //Velocidad constante
								Vector3 NewPosPersona = Persona.gameObject.transform.localPosition;
								NewPosPersona.x = NewPosPersona.x + PosDif.x * velocidad;
								NewPosPersona.y = NewPosPersona.y + PosDif.y * velocidad;
								NewPosPersona.z = NewPosPersona.z + PosDif.z * velocidad;
								Persona.gameObject.transform.localPosition = NewPosPersona;
						}
				}

	}

	void MovPerro () {

		if(Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.S))
			transform.Translate(-Vector3.forward * moveSpeed/3 * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.D))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);


	}
}
