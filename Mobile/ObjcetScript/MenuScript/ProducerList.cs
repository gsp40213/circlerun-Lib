using UnityEngine;
using System.Collections;

public class ProducerList : MonoBehaviour {

	public Sprite producerListImage;
	public float width, height;

	DpiResolution dpiResolution = new DpiResolution();

	// Use this for initialization
	void Start () {
		ProducerListGameobjcetComponentSetting ();
	}


	/**
	 * ProducerListGameobjcetComponentSetting
	 * TODO Setting ProducerListGameobjcet add Component
	 */ 
	void ProducerListGameobjcetComponentSetting(){

		gameObject.transform.position = new Vector3 (dpiResolution.setScreenWidth(-width), dpiResolution.setScreenHeight(height));

		gameObject.AddComponent<SpriteRenderer> ().sprite = producerListImage;
		gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		gameObject.AddComponent<BoxCollider> ();

	}
}
