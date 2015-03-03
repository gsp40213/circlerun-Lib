using UnityEngine;
using System.Collections;

public class Start_Button : MonoBehaviour {
	
	public Sprite buttonImage;
	public float width, height;

	DpiResolution dpiResolution = new DpiResolution();

	void Start(){
		StartGameobjcetComponentSetting ();
	}

	/**
	 * StartGameobjcetComponentSetting
	 * TODO Setting StartGameobjcet add Component
	 */
	void StartGameobjcetComponentSetting(){

		gameObject.transform.position = new Vector3 (dpiResolution.setScreenWidth (+width) * width, dpiResolution.setScreenHeight (height));
		gameObject.AddComponent<SpriteRenderer>().sprite = buttonImage;
		gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		gameObject.AddComponent<BoxCollider> ();

	}
}