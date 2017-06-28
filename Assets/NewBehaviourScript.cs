using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour {
	int i = 0;

	
	void Start () {
		InvokeRepeating("timer_Tick", 0, 1);

	}

	void timer_Tick()
	{
		TextMesh text = GetComponent<TextMesh>();
		text.text = DateTime.Now.ToString ("h:mm:ss tt");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
