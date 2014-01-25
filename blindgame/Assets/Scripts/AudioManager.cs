using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour{

	public static AudioClip clip1;
	public static AudioClip clip2;
	public static AudioSource source;
	public static AudioClip myClip;
	private static AudioManager instance = null;
	public static AudioManager Instance
	{
		get
		{
			if(instance == null)
			{
				GameObject go = new GameObject("AudioManager");
				instance = go.AddComponent<AudioManager>();
				source  = go.AddComponent<AudioSource>();
				DontDestroyOnLoad(go);

				clip1 = Resources.Load("Sounds/Old-Car-1") as AudioClip;
				clip2 = Resources.Load("Sounds/Old-Car-2") as AudioClip;
			}
			return instance;
		}
	}

	public static void setClip(int clip)
	{
		switch (clip) {
		case 1: myClip = clip1; break;
		case 2: myClip = clip2; break;
		}
		source.clip = myClip;
	}
	public static void StartSound()
	{
		if (source != null)
		{
			if(source.clip != null)
			{
				source.volume = 1f;
				source.Play();
				Debug.Log("Ejecuto una vez el sonido");
			}
		}
	}
}
