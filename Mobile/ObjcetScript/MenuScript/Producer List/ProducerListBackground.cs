using UnityEngine;
using System.Collections;

public class ProducerListBackground : MonoBehaviour {

	public Sprite background1;

	[Range(0.001f, 1f)]
	public float animationfpx;
	DpiResolution dpiResolution = new DpiResolution();
	Collection collection = new Collection();

	// Use this for initialization
	void Start () {
		BackgroundGameobjcetComponetSetting ();
	}


	void Update(){

//		gameObject.transform.localScale = new Vector3 (dpiResolution.getScreenWidth () / dpiResolution.getScreenWidth (), dpiResolution.getScreenHeight()/dpiResolution.getScreenHeight());
	}

	/**
	 * BackgroundGameobjcetComponetSetting
	 * TODO Setting background gameobjcet add componet and Setting
	 */ 
	void BackgroundGameobjcetComponetSetting(){
		gameObject.AddComponent<SpriteRenderer> ().sprite = background1;
		gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 3;

	}
}