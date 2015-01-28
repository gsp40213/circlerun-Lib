using UnityEngine;
using System.Collections;

public class GUIComponents{
	
	Texture image;
	float buttonWidthPostiton, buttonHeightPosistion;
	bool OnClick;
	
	DpiResolution dpiResolution = new DpiResolution ();
	
	public bool getImageButton(Texture buttonimage, GUIStyle buttonStyle, float width, float height){
		
		buttonWidthPostiton = dpiResolution.getScreenWidth () / dpiResolution.setScreenWidth (100f);
		buttonHeightPosistion = dpiResolution.getScreenHeight () / dpiResolution.setScreenHeight (100f);
		
		this.image = buttonimage;
		
		if(GUI.Button (new Rect (buttonWidthPostiton, buttonHeightPosistion, image.width/width, image.height/height), buttonimage, buttonStyle))
			this.OnClick = true;
		return this.OnClick;
	}

	public float getHorizontalSlider (Rect screenRect, float sliderValue, float sliderMaxValue, GUIStyle slider, GUIStyle thumb){

		screenRect.x += screenRect.width; 
		
		sliderValue = GUI.HorizontalSlider (screenRect, sliderValue, 0.0f, sliderMaxValue, slider, thumb);
		return sliderValue;
	}
}