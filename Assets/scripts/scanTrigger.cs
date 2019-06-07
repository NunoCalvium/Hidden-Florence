﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scanTrigger : MonoBehaviour {
	public ScannerEffectDemo scanScript;
	[SerializeField] private bool scanning = false;
	private Camera cam;
	[SerializeField] private churchScript church;
	[SerializeField] private Image img;
	[SerializeField] private  Color m_NewColor;
	[SerializeField] private mainPaintingScript painting;

	void Start() {
		cam = Camera.main;
		scanScript = cam.GetComponent<ScannerEffectDemo>();
		church = GameObject.FindGameObjectWithTag("church").GetComponent<churchScript>();
		painting = GameObject.FindGameObjectWithTag("altarpiece").GetComponent<mainPaintingScript>();
	}

    void OnTriggerEnter(Collider col) {
		Debug.Log("scanning0");
        if (col.gameObject == Camera.main.gameObject && !scanning) {
			StartCoroutine(scanningEvents());
		}
    }	

	IEnumerator scanningEvents(){
		Debug.Log("scanning1");
		painting.startFade();
		yield return new WaitForSeconds (3f);
		scanScript.startPainting();
		church.animation.SetTrigger("go");
		scanning = true;		
		img.color = m_NewColor;
	}
}
