using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class ButtonController : MonoBehaviour {
	public ButtonController button;

	public void OnClick(){
		if (button == null){
			throw new System.Exception("Button instance is null!!");
		}

		button.OnClick(this.gameObject.name);
	}

	protected virtual void OnClick(string objectName){
		// 呼ばれることはない
		Debug.Log("Base Button");
	}
}
