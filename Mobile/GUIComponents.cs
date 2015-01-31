using UnityEngine;
using System.Collections;

public class GUIComponents{
	
	Texture image;
	float buttonWidthPostiton, buttonHeightPosistion;
	bool OnClick;
	Rect test;

	/**
	 * ImageButton
	 * TODO ImageButton function(wordPosistionSize, image, style) 
	 */
	
	public bool getImageButton(Rect rectScreenRect, Texture image, GUIStyle style){

		OnClick = GUI.Button (rectScreenRect, image, style);

		return OnClick;
	}

	/**
	 * Windows
	 * TODO Windows function(wordPosistionSize, windwfunctuin, title)
	 */
	public void getWindwos (int id, Rect screenRect, GUI.WindowFunction windowFunctuin, string title){
		 this.test = GUI.Window (id, screenRect, windowFunctuin, title);

	}

	/**
	 * HorizontalSlider
	 * TODO HorizontalSlider function(wordPosistionSize, SliderValue, MaxValue, SliderStyle, ThumbStyle)
	 */
	public float getHorizontalSlider (Rect screenRect, float sliderValue, float sliderMaxValue, GUIStyle slider, GUIStyle thumb){

		screenRect.x += screenRect.width; 
		sliderValue = GUI.HorizontalSlider (screenRect, sliderValue, 0.0f, sliderMaxValue, slider, thumb);

		return sliderValue;
	}
}