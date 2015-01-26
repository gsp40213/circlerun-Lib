using UnityEngine;
using System.Collections;

/**
 * getTouchInfo
*/
public class TouchInfo : MonoBehaviour
{
	
	/**
	 * getPositionX
	 * 
	 * @retrun {float}Position.X
	 */
	public void getPositionX ()
	{
		//test code
		for (int i = 0; i < Input.touchCount; ++i) {
			Touch touch = Input.GetTouch (i);
			if (touch.phase == TouchPhase.Began) {
				 if (touch.position.x > (Screen.width/2)) {
					GUI.Label(new Rect(10,10,50,50),touch.position.x.ToString());
            	}	
			}
			GUI.Label(new Rect(10,10,50,50),touch.position.x.ToString());
		}
	}
	
	/**
	 * getPositionY
	 * 
	 * @return {float}Position.Y
	 */
	public void getPositionY ()
	{
		
	}
	
	/**
	 * getTouch
	 * 
	 * @return Touch GameObject Name
	 */
	public void getTouch ()
	{

	}
	
	/**
	 * isTouch
	 * 
	 * @param {GameObject}Object
	 * @return {bool}isTouch?
	 */
	public void isTouch ()
	{
		
	}
}
