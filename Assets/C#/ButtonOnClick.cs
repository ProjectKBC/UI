using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOnClick : ButtonController {
    
	Camera mainCamera;
    GameObject menu;
    GameObject multi;

	void Start(){
		mainCamera = Camera.main.gameObject.GetComponent<Camera>();
        menu = GameObject.FindWithTag("menu");
        multi = GameObject.FindWithTag("multi");
        multi.SetActive(false);

	}
	
	protected override void OnClick(string objectName){ 

		if ("solo".Equals (objectName)) {
			this.Button1Click ();
		} else if ("multi".Equals (objectName)) {
			this.Button2Click ();
		} else if ("option".Equals (objectName)) {
			this.Button3Click ();
		}else{
			throw new System.Exception("Not implemented!!");
		}
	}

	private void Button1Click(){
		Debug.Log("Button1 Click");
	}

	private void Button2Click(){
		Debug.Log("Button2 Click");
        menu.SetActive (false);
        multi.SetActive(true);
		mainCamera.transform.position = new Vector3 (-50f, 1f, 0f);
	}

	private void Button3Click(){
		Debug.Log("Button3 Click");
	}
}
