using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

	public float speed = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 carpos = this.transform.position;
		if (this.transform.position.z <= -100f) 
		{
			carpos.z = 120f;
		}
		else
			carpos.z -= speed;
		this.transform.position = carpos;
	}


}
