using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {

	public GameObject start, produerlist, skill, fraction, setting, exit, menu, producerList, producerListButton;

	public Sprite buttonImage1, produerlistImage1, skillImage1, fractionImage1, settingImage1, exitImage1, producerListButtonImage1;

	// Update is called once per frame
	void Update () {
		OnClickSprite ();
	}

	/**
	 * OnClickSprite
	 * TODO Setting Sprite Onclik
	 */
	void OnClickSprite(){
		
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		
		RaycastHit hits;
		
		if(Input.GetMouseButton(0)){
			if(Physics.Raycast(ray, out hits, 100)){
				string spriteName = hits.collider.gameObject.name;
				View(spriteName);
			}
		}else{
			NoOnClick();
		}
	}

	/**
	 * NoOnClick
	 * TODO Setting Sprite NoClick
	 */ 
	void NoOnClick(){
		start.GetComponent<SpriteRenderer> ().sprite = buttonImage1;
		produerlist.GetComponent<SpriteRenderer> ().sprite = produerlistImage1;
		skill.GetComponent<SpriteRenderer> ().sprite = skillImage1;
		fraction.GetComponent<SpriteRenderer> ().sprite = fractionImage1;
		setting.GetComponent<SpriteRenderer> ().sprite = settingImage1;
		exit.GetComponent<SpriteRenderer> ().sprite = exitImage1;
		producerListButton.GetComponent<SpriteRenderer>().sprite = produerlistImage1;

		if(Input.GetKey(KeyCode.Escape)){
			menu.SetActive(true);
			producerList.SetActive(false);
		}
	}

	/**
	 * View
	 * TODO Sprite OnClick after View
	 */ 
	void View(string name){
		if(name == "StartButton"){

		}
		if(name == "ProducerList"){
			producerList.SetActive(true);
			menu.SetActive(false);
		}
		if(name == "Skill"){

		}
		if(name == "Fraction"){

		}
		if(name == "Setting"){

		}
		if(name == "Exit"){
			Application.Quit();
		}
		if(name == "ProducerListButton"){
			menu.SetActive(true);
			producerList.SetActive(false);
		}
	}
}