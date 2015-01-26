using UnityEngine;
using System.Collections;

/**
 * SystemSetting
 * 
 * @class {void}setAlertDialog -> line 10 - 55
 */
public class SystemSetting {
	
	//setAlertDialog Varaible Area
	int zIndex;
	string Title;
	
	/**
	 * setAlertDialog
	 * TODO setAlertDialog Message
	 * 
	 * @param {string}Title
	 * @param {string}Message
	 */
	public void setAlertDialog(string Title){
		this.Title = Title;
		WindowSetting();
		zIndex++;
	}
	
	/**
	 * getAlertDialog
	 * TODO call Last Alert Message
	 */
	public void getAlertDialog(){
		WindowSetting();	
	}
	
	/**
	 * WindowSetting
	 * OnGUI Windows Setting
	 */
	public void WindowSetting (){
	
		DpiResolution dpiResolution = new DpiResolution ();

		float windowsWidth = dpiResolution.getScreenWidth(), widowsHeight = dpiResolution.setScreenHeight(200f), height = dpiResolution.setScreenHeight(80f);
		GUI.Window (zIndex, new Rect(dpiResolution.getScreenWidth()/dpiResolution.getScreenWidth(), dpiResolution.getScreenHeight()/dpiResolution.getScreenHeight() + height, 
		                             dpiResolution.setScreenWidth(windowsWidth), dpiResolution.setScreenHeight(widowsHeight)), WindowLabelSetting, this.Title); 

	}
	/**
	 * WindowLabelSetting
	 * Setup Label Message
	 */
	void WindowLabelSetting(int windowID){
	
	}
}