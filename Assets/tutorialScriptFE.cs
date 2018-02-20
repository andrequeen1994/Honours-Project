using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class tutorialScriptFE : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vButtonObject;

	// Use this for initialization
	void Start () {

		vButtonObject = GameObject.Find("tutorialButton");
		vButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler(this);

	}
	
	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){
		Debug.Log("Button Down!!!!");

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb){
		Debug.Log("Button Released!!!!");
//		MeshRenderer targetMeshRenderer = this.GetComponent<MeshRenderer>();
//		Destroy(targetMeshRenderer);
//		MeshFilter targetMesh = this.GetComponent<MeshFilter>();
//		Destroy(targetMesh);
	}
}
