using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour {

	public int clipnum;
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
		//AudioManager.Instance.audio.clip = clip;
		//if (AudioManager.Instance.audio.isPlaying == false)
		{
			if(this.GetComponent<AudioSource>() != null)
			{
				this .transform.GetChild(0).GetComponent<AudioSource>().Play();
			}
			//AudioManager.setClip(clipnum);
			//AudioManager.StartSound();
		}
		//Debug.Log ("Ejecutando sonido");

	}
}
