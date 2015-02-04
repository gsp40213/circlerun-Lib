using UnityEngine;
using System.Collections;

/**
usage:

private float touchX;

void update(){
	TouchInfo touch = new TouchInfo();
	touch.listen();
	touchX = touch.getPositionX();
	Debug.log(touch.getPositionX());
}
void OnGUI(){
	GUI.Label(new React(25,25,125,25),"Listen for touch position x : "+touchX);
}
**/


/**
 * getTouchInfo
*/
public class TouchInfo : MonoBehaviour
{
	private Touch touch;
	
	/**
	* Listen
	* listen touch move
	*
	*/
	public void listen(){
		touch = Input.GetTouch(0);
	}
	
	/**
	 * getPositionX
	 * 
	 * @retrun {float}Position.X
	 */
	public void getPositionX ()
	{
		return touch.position.x;
	}
	
	/**
	 * getPositionY
	 * 
	 * @return {float}Position.Y
	 */
	public void getPositionY ()
	{
		return touch.position.y;
	}
	
	/**
	 * getTouch
	 * 
	 * @return Touch GameObject Name
	 */
	public void getTouch ()
	{
		//TODO Emit Ray-cast get Object ID.
	}
	
	/**
	 * isTouch
	 * 
	 * @param {GameObject}Object
	 * @return {bool}isTouch?
	 */
	public void isTouch ()
	{
		//TODO RETURN if touch screen
		return ture;
	}
}
