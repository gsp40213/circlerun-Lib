using UnityEngine;
using System.Collections;

public class Fraction : MonoBehaviour {

	public Sprite FractionImage;

	public float width, height;
	
	DpiResolution dpiResolution = new DpiResolution();


	// Use this for initialization
	void Start () {
		FractionGameobjcetComponentSetting ();
	}

	/**
	 * FractionGameobjcetComonentSetting
	 * TODO setting Fraction add comonent 
	 */ 
	void FractionGameobjcetComponentSetting(){
		gameObject.transform.position = new Vector3 (dpiResolution.setScreenWidth (-width) * width, dpiResolution.setScreenHeight (height));
		gameObject.AddComponent<SpriteRenderer>().sprite = FractionImage;
		gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
		gameObject.AddComponent<BoxCollider> ();
	}
}
