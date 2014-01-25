using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Texture2D menu;
	public Texture2D credits;
	public Texture2D levels;
	public Rect rect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		GUI.DrawTexture (new Rect(0,0,Screen.width,Screen.height),menu);
		if (GUI.Button (rect, "Button")) {
			Debug.Log("boton accionado");
				}
		Debug.DrawLine (new Vector3 (rect.x,rect.y,0f ), new Vector3 (rect.x+rect.width,rect.y,0f));
		Debug.DrawLine (new Vector3 (rect.x+rect.width,rect.y,0f ), new Vector3 (rect.x+rect.width,rect.y+rect.height,0f));
		Debug.DrawLine (new Vector3 (rect.x,rect.y,0f ), new Vector3 (rect.x,rect.y+rect.height,0f));
		Debug.DrawLine (new Vector3 (rect.x,rect.y+rect.height,0f ), new Vector3 (rect.x+rect.width,rect.y+rect.height,0f));
	}

}
