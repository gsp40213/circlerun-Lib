using UnityEngine;
using System.Collections;

/**
 * SystemSetting
 * 
 * @class {void}setAlertDialog -> line 10 - 55
 */
public class SystemSetting{

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
		getWindowSetting();
		zIndex++;
	}

	/**
	 * WindowSetting
	 * OnGUI Windows Setting
	 * WindowsfunctionSetting can in another class use unction
	 */
	public void getWindowSetting (){

		DpiResolution dpiResolution = new DpiResolution ();
		GUIComponents guiCompoents = new GUIComponents ();
		Rect wordPosition = new Rect (dpiResolution.getScreenWidth()/dpiResolution.getScreenWidth(),dpiResolution.getScreenHeight()/dpiResolution.getScreenWidth(), 
		                              dpiResolution.getScreenWidth(), dpiResolution.getScreenHeight()/1.2f);
		Test3 test = new Test3 ();

		guiCompoents.getWindwos (this.zIndex, wordPosition, test.testWidnws, this.Title);

	}
}