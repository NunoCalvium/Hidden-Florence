﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class triggerOriginal : MonoBehaviour {

//[SerializeField]
//	private ARReferenceImage referenceImage;

	[SerializeField]
	private GameObject prefabToGenerate;

	private GameObject imageAnchorGO;
	[SerializeField] private debugLogTextScript dbScript;

	// Use this for initialization
	void Start () {
		//UnityARSessionNativeInterface.ARImageAnchorAddedEvent += AddImageAnchor;
		//UnityARSessionNativeInterface.ARImageAnchorUpdatedEvent += UpdateImageAnchor;
		//UnityARSessionNativeInterface.ARImageAnchorRemovedEvent += RemoveImageAnchor;

	}

	//void AddImageAnchor(ARImageAnchor arImageAnchor)
	//{
	//	Debug.Log ("image anchor added");
	//	if (arImageAnchor.referenceImageName == referenceImage.imageName) {
	//		Vector3 position = UnityARMatrixOps.GetPosition (arImageAnchor.transform);
	//		Quaternion rotation = UnityARMatrixOps.GetRotation (arImageAnchor.transform);
	//		dbScript.addToString("secondary Instantiate prefab");

	//		imageAnchorGO = Instantiate<GameObject> (prefabToGenerate, position, rotation);
	//	}
	//}

	//void UpdateImageAnchor(ARImageAnchor arImageAnchor)
	//{
	//	Debug.Log ("image anchor updated");
	//	if (arImageAnchor.referenceImageName == referenceImage.imageName) {
	//		imageAnchorGO.transform.position = UnityARMatrixOps.GetPosition (arImageAnchor.transform);
	//		imageAnchorGO.transform.rotation = UnityARMatrixOps.GetRotation (arImageAnchor.transform);
	//	}

	//}

	//void RemoveImageAnchor(ARImageAnchor arImageAnchor)
	//{
	//	Debug.Log ("image anchor removed");
	//	if (imageAnchorGO) {
	//		GameObject.Destroy (imageAnchorGO);
	//	}

	//}

	//void OnDestroy()
	//{
	//	UnityARSessionNativeInterface.ARImageAnchorAddedEvent -= AddImageAnchor;
	//	UnityARSessionNativeInterface.ARImageAnchorUpdatedEvent -= UpdateImageAnchor;
	//	UnityARSessionNativeInterface.ARImageAnchorRemovedEvent -= RemoveImageAnchor;

	//}

	// Update is called once per frame
	void Update () {
		
	}
}
