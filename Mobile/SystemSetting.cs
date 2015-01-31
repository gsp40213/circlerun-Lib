using UnityEngine;
using System.Collections;

public class SystemSetting : MonoBehaviour{

	//ImageButton in a Image and buttonStyle
	public Texture image;
	public GUIStyle buttonstyle;

	/**
	 * WindowSetting
	 * OnGUI Windows Setting
	 * WindowsfunctionSetting can in another class use unction
	 */
	public void OnGUI(){

		DpiResolution dpiResolution = new DpiResolution ();
		GUIComponents guiCompoents = new GUIComponents ();
		Rect wordPosition = new Rect (dpiResolution.getScreenWidth()/dpiResolution.getScreenWidth(),dpiResolution.getScreenHeight()/dpiResolution.getScreenWidth(), 
		                              dpiResolution.getScreenWidth(), dpiResolution.getScreenHeight()/1.2f);

		guiCompoents.setAlertDialog ("123");
		guiCompoents.getWindwos (guiCompoents.windowsId, wordPosition, WindwosMessage, guiCompoents.windowsTitle);

	}


	void WindwosMessage(int id){

		GUIComponents guiCompents = new GUIComponents ();
		DpiResolution dpiResolution = new DpiResolution ();
		Rect wordPosition = new Rect (dpiResolution.getScreenWidth()/dpiResolution.getScreenWidth(),dpiResolution.getScreenHeight()/dpiResolution.getScreenWidth(), 
		                              image.width/5, image.height/2);
		if(guiCompents.getImageButton (wordPosition,image, buttonstyle)){
			Debug.Log("ok");
		}
	}
}