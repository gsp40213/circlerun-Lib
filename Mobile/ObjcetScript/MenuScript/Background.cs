using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public Sprite menuBackground1, menuBackground2;

	[Range(0.001f, 1f)]
	public float animationfpx;

	Collection collcetion = new Collection();
	DpiResolution dpiResolution = new DpiResolution();

	void Start () {
		BackgroundGameobjcetComponentSetting ();
	}

	void Update () {
		BackgroundAnimation ();
	}

	/**
	 * BackgroundGameobjcetComponentSetting
	 * TODO Setting Background add Component
	 */ 
	void BackgroundGameobjcetComponentSetting(){

		gameObject.AddComponent<SpriteRenderer> ().sprite = menuBackground1;
		gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 0;
		gameObject.transform.localScale = new Vector3 (dpiResolution.getScreenWidth()/dpiResolution.getScreenWidth(), dpiResolution.getScreenHeight()/dpiResolution.getScreenHeight());
	}

	/**
	 * BackgroundAnimation
	 * TODO BackgroundAnimation time switching sprite
	 */ 
	void BackgroundAnimation(){
		if(collcetion.setSelectTime(animationfpx) %2 == 0){
			gameObject.GetComponent<SpriteRenderer>().sprite = menuBackground2;
		}else{
			gameObject.GetComponent<SpriteRenderer>().sprite = menuBackground1;
		}
	}
}