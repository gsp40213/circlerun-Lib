using UnityEngine;
using System.Collections;

public class GUIComponents{

	Texture image;
	GUIStyle style;
	float buttonWidthPostiton, buttonHeightPosistion;
	bool OnClick = false;
	float minMaxVlaue;

	DpiResolution dpiResolution = new DpiResolution ();

	public bool getImageButton(Texture buttonimage, GUIStyle buttonStyle, float width, float height){

		buttonWidthPostiton = dpiResolution.getScreenWidth () / dpiResolution.setScreenWidth (100f);
		buttonHeightPosistion = dpiResolution.getScreenHeight () / dpiResolution.setScreenHeight (100f);

		this.image = buttonimage;

		if(GUI.Button (new Rect (buttonWidthPostiton, buttonHeightPosistion, image.width/width, image.height/height), buttonimage, buttonStyle))
			this.OnClick = true;
		return this.OnClick;
	}

	public float getHorizontalSlider(float value, float width, float height, float min, float max){

		float HorizontalSliderWidth =  dpiResolution.getScreenWidth()/dpiResolution.setScreenWidth(100f);
		float HorizontalSliderHeight = dpiResolution.getScreenHeight()/dpiResolution.setScreenHeight(140f);

		this.minMaxVlaue = value;

		GUI.HorizontalSlider (new Rect (HorizontalSliderWidth, HorizontalSliderHeight, width, height), value, min, max);

//		Debug.Log (value);

		return this.minMaxVlaue;
	}
}