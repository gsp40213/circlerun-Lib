using UnityEngine;
using System.Collections;

public class Test3 : MonoBehaviour{


	SystemSetting systemSetting = new SystemSetting ();

	bool sw = false;

	void OnGUI(){

		if(GUI.Button(new Rect(Screen.width/Screen.width, Screen.height/Screen.height, 100, 50),"aaa")){
			sw = !sw;
		}

		if(sw){
			systemSetting.setAlertDialog("test");
			systemSetting.getWindowSetting ();
		}
	}
	public void testWidnws(int Id){

	}
}