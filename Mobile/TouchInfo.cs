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
		return Input.GetTouch(0).position.x;
	}
	
	/**
	 * getPositionY
	 * 
	 * @return {float}Position.Y
	 */
	public void getPositionY ()
	{
		return Input.GetTouch(0).position.y; 
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
