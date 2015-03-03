using UnityEngine;
using System.Collections;

public class Setting : MonoBehaviour {

	public Sprite SettingImage;
	
	public float width, height;
	DpiResolution dpiResolution = new DpiResolution();

	// Use this for initialization
	void Start () {
		SettingGameobjcetComponentSetting ();
	}
	
	/**
	 * SettingGameobjcetComponentSetting
	 * TODO setting SettingGameobject add Component
	 */ 
	void SettingGameobjcetComponentSetting () {

		gameObject.transform.position = new Vector3 (dpiResolution.setScreenWidth (-width), dpiResolution.setScreenHeight (height));

		gameObject.AddComponent<SpriteRenderer> ().sprite = SettingImage;
		gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		gameObject.AddComponent<BoxCollider> ();

	}
}