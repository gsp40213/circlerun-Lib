using UnityEngine;
using System.Collections;

public class SystemSetting {

	void OnGUI(){
		setAlertDialog ();
	}

	public void setAlertDialog (){

		DpiResolution dpiResolution = new DpiResolution ();

		float windowsWidth = dpiResolution.getScreenWidth(), widowsHeight = dpiResolution.setScreenHeight(200f), height = dpiResolution.setScreenHeight(80f);

		Debug.Log (height);

		GUI.Window (0, new Rect(dpiResolution.getScreenWidth()/dpiResolution.getScreenWidth(), dpiResolution.getScreenHeight()/dpiResolution.getScreenHeight() + height,
		                        dpiResolution.setScreenWidth(windowsWidth), dpiResolution.setScreenHeight(widowsHeight)), GameSetting, "GameSetting"); 
			
	}

	void GameSetting(int windowID){

	}
}
