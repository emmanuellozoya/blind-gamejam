using UnityEngine;
using System.Collections;

public class Mano : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if(this.transform.collider.bounds.Intersects())
	}

	void OnCollisionEnter (Collision other)
	{
		//other.gameObject.GetComponent<Obstaculo> ().EjecutaSonido();
	}
}
