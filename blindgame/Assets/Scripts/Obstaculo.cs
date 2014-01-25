using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision other)
	{
		EjecutaSonido ();
	}

	public void EjecutaSonido()
	{
		if(this .transform.GetChild(0).GetComponent<AudioSource>() != null)
		{
			this .transform.GetChild(0).GetComponent<AudioSource>().Play();
		}
	}
}
