using UnityEngine;
using System.Collections;

public class ProducerListButton : MonoBehaviour {

	public Sprite buttonImage;
	public float width, height, buttonImageSizeWidth, buttonImageHeight;
	
	DpiResolution dpiResolution = new DpiResolution();

	// Use this for initialization
	void Start () {
		ProducerListButtonGameobjcetComponetSetting ();
	}

	void Update(){
		gameObject.transform.localScale = new Vector3 (dpiResolution.setScreenWidth(buttonImageSizeWidth), dpiResolution.setScreenHeight(buttonImageHeight));
	}

	void ProducerListButtonGameobjcetComponetSetting(){

		gameObject.transform.position = new Vector3 (dpiResolution.setScreenWidth (+width), dpiResolution.setScreenHeight (+height));
		gameObject.AddComponent<SpriteRenderer>().sprite = buttonImage;
		gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		gameObject.AddComponent<BoxCollider> ().size = new Vector3 (0.31f, 0.45f, 0);

	}
}
