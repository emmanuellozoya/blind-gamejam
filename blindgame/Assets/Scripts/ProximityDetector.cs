using UnityEngine;
using System.Collections;

public class ProximityDetector : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			string propiedad = "_VisibleDistance";
			Debug.Log(propiedad +": " + renderer.material.HasProperty(propiedad).ToString());
			//Debug.Log(propiedad +": " + renderer.sharedMaterial.GetVector(propiedad));
			renderer.sharedMaterial.SetVector(propiedad, player.position);
		}
	}
}
