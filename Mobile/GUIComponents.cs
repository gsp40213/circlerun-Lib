using UnityEngine;
using System.Collections;

public class GUIComponents{

	//ImageButton OnClick View
	bool imageButtonOnClick;

	// windwosTitleName and WindwosIdNumber
	public string windowsTitle;
	public int windowsId;

	/**
	 * ImageButton
	 * TODO ImageButton function(wordPosistionSize, image, style) 
	 */
	
	public bool getImageButton(Rect rectScreenRect, Texture image, GUIStyle style){

		imageButtonOnClick = GUI.Button (rectScreenRect, image, style);

		return imageButtonOnClick;
	}

	/**
	 * setAlertDialog
	 * TODO setAlertDialog Message
	 * 
	 * @param {string}Title
	 * @param {string}Message
	 */
	public void setAlertDialog(string Title){
		this.windowsTitle = Title;
		windowsId++;
	}

	/**
	 * Windows
	 * TODO Windows function(wordPosistionSize, windwfunctuin, title)
	 */
	public void getWindwos (int id, Rect screenRect, GUI.WindowFunction windowFunctuin, string title){

		title = this.windowsTitle;
		id = this.windowsId;
		GUI.Window (id, screenRect, windowFunctuin, title);
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