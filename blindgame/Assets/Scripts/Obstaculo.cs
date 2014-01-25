using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour {

	public Material Shaded;
	public Material[] UnShadedRegular;
	// Use this for initialization
	void Start () {
		if (Shaded == null) {
			Shaded = Resources.Load("Standard Assets/Toon Shading/Sources/Toony-Lighted Outline") as Material;
		}
		this.renderer.enabled = false;
		UnShadedRegular = this.renderer.materials;
		this.renderer.materials = new Material[]{};
		this.renderer.material = Shaded;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.transform.name == "perro") {
						MuestraObjeto ();
				} else {
			MuestraShadersIniciales(); 
						EjecutaSonido ();
				}
	}

	public void EjecutaSonido()
	{
		if(this .transform.GetChild(0).GetComponent<AudioSource>() != null)
		{
			this .transform.GetChild(0).GetComponent<AudioSource>().Play();
		}
	}

	void MuestraShadersIniciales ()
	{
		this.renderer.materials = UnShadedRegular;
	}

	void MuestraObjeto ()
	{
		this.renderer.enabled = true;
	}

}
