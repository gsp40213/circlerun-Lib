using UnityEngine;
using System.Collections;

public class Collection{

	/**
	 * setSelectRamdomNubmer
	 * TODO Select a combination object
	 * @param {int} arraymin, arramax
	 * @param return{int} randomNumber
	 */
	public int setSelectRamdomNumber(int arraymin, int arraymax){

		int randomNumber = Random.Range (arraymin, arraymax);

		return randomNumber;
	}

	/**
	 * setcreateBublle
	 * TODO create Gameobjcet
	 * @param{Gameobjcet} gameobjcet
	 * @parm return {Gameobjcet} gameobjcet
	 */
	public GameObject setcreateBublle(GameObject gameObjcet){

		MonoBehaviour.Instantiate (gameObjcet);

		return gameObjcet;
	}

	/**
	 * Sprite image
	 * TODO setSprite
	 * @param {Textrue2D} image
	 * @param retrun sprite
	 * @Watch out only SpriteRennder user
	 */
	public Sprite setSprite(Texture2D image){

		Sprite sprite = Sprite.Create (image, new Rect (0, 0, image.width, image.height),new Vector2(0.5f,0.5f) ,129f);

		return sprite;
	}

	/**
	 * setSelectTime
	 * TODO Timing Time
	 * @param {float} inputTimeNumber
	 * @param return {float} SystemTime
	 */ 
	public float setSelectTime(float inputTimeNumber){
		float systemTime = Time.time + inputTimeNumber;
		return systemTime;
	}
}
