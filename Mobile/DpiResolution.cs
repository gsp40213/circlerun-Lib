using UnityEngine;
using System.Collections;

public class DpiResolution {

	//phone size
	float width = Screen.width / 1200 / 2;
	float height = Screen.height / 1920 / 2;

	public float setScreenWidth(float setWidth){

		setWidth += width;

		return setWidth;
	}
	
	public float setScreenHeight(float setHeight){

		setHeight += height;

		return setHeight;
	}

	public float getScreenWidth(){
		return Screen.width;
	}
	public float getScreenHeight(){
		return Screen.height;
	}
}