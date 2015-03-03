using UnityEngine;
using System.Collections;

public class Skill : MonoBehaviour {

	public Sprite skillImage;
	public float width, height;
	
	DpiResolution dpiResolution = new DpiResolution();

	// Use this for initialization
	void Start () {
		SkillGameobjcetComponentSetting ();
	}

	/**
	 * SkillGameobjcetComponentSetting
	 * TODO setting skillGameobjcet add comonent
	 */ 
	void SkillGameobjcetComponentSetting(){

		gameObject.transform.position = new Vector3 (dpiResolution.setScreenWidth(width), dpiResolution.setScreenHeight(height));
		
		gameObject.AddComponent<SpriteRenderer> ().sprite = skillImage;
		gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		gameObject.AddComponent<BoxCollider> ();
	}
}
