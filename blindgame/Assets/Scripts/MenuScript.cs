using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Texture2D menu;
	public Texture2D credits;
	public Texture2D levels;
	public Rect rect;
	public Rect rectCredits;
	public Rect rectBackToMenu;
	public Rect rectLevel1;
	public Rect rectLevel2;
	public Rect rectLevel3;
	private string currentMenu;

	// Use this for initialization
	void Start () {
		rect.x = 355f;
		rect.y = 478.6f;
		rect.width = 91f;
		rect.height = 33.3f;

		rectCredits.x = 743.4f;
		rectCredits.y = 15.5f;
		rectCredits.width = 34.8f;
		rectCredits.height = 30.4f;

		rectBackToMenu.x = 375.4f;
		rectBackToMenu.y = 498.2f;
		rectBackToMenu.width = 52f;
		rectBackToMenu.height = 55.6f;

		rectLevel1.x = 178.1f;
		rectLevel1.y = 300.4f;
		rectLevel1.width = 106.4f;
		rectLevel1.height = 175.4f;

		rectLevel2.x = 349.7f;
		rectLevel2.y = 300.4f;
		rectLevel2.width = 106.4f;
		rectLevel2.height = 175.4f;

		rectLevel3.x = 511.2f;
		rectLevel3.y = 300.4f;
		rectLevel3.width = 106.4f;
		rectLevel3.height = 175.4f;


		currentMenu = "main";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		if (currentMenu == "main") {
			drawMain();
		} else if (currentMenu == "levels") {
			drawLevels();
		} else if (currentMenu == "credits") {
			drawCredits();
		}


	}

	void drawMain() {
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), menu);
		//Debug.DrawLine (new Vector3 (rect.x,rect.y,0f ), new Vector3 (rect.x+rect.width,rect.y,0f));
		//Debug.DrawLine (new Vector3 (rect.x+rect.width,rect.y,0f ), new Vector3 (rect.x+rect.width,rect.y+rect.height,0f));
		//Debug.DrawLine (new Vector3 (rect.x,rect.y,0f ), new Vector3 (rect.x,rect.y+rect.height,0f));
		//Debug.DrawLine (new Vector3 (rect.x,rect.y+rect.height,0f ), new Vector3 (rect.x+rect.width,rect.y+rect.height,0f));
		if (GUI.Button (rect, "", GUIStyle.none)) {
			currentMenu = "levels";
		}
		if (GUI.Button (rectCredits, "", GUIStyle.none)) {
			currentMenu = "credits";
		}
	}

	void drawCredits() {
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), credits);
		if (GUI.Button (rectBackToMenu, "", GUIStyle.none)) {
			currentMenu = "main";
		}
	}

	void drawLevels() {
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), levels);
		if (GUI.Button (rectLevel1, "", GUIStyle.none)) {
			Debug.Log("Load Level 1");
		}
		if (GUI.Button (rectLevel2, "", GUIStyle.none)) {
			Debug.Log("Load Level 2");
		}
		if (GUI.Button (rectLevel3, "", GUIStyle.none)) {
			Debug.Log("Load Level 3");
		}
	}

}
