using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	public Sprite exitImage;
	
	public float width, height;
	DpiResolution dpiResolution = new DpiResolution();

	// Use this for initialization
	void Start () {
		ExitGameobjcetComponentSetting ();
	}
	
	/**
	 * ExitGameobjcetComponentSetting
	 * TODO Setting exitGameobjcet add component
	 */ 
	void ExitGameobjcetComponentSetting () {

		gameObject.transform.position = new Vector3(dpiResolution.setScreenWidth(-width), dpiResolution.setScreenHeight(height));

		gameObject.AddComponent<SpriteRenderer> ().sprite = exitImage;
		gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		gameObject.AddComponent<BoxCollider> ();
	}
}