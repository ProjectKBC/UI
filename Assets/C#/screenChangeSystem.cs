using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenChangeSystem : MonoBehaviour {
	Button solo;
	Button multi;
	Button option;

	void Start () {

		solo = GameObject.Find("Buttons/solo").GetComponent<Button>();

		multi = GameObject.Find("Buttons/multi").GetComponent<Button>();

		option = GameObject.Find("Buttons/option").GetComponent<Button>();

		solo.Select();
	}

	// Update is called once per frame
	void Update () {
	}
}
