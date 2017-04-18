using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizedText : MonoBehaviour {

	public LocalizationEnum.Key key;

	// Use this for initialization
	void Start () {
		updateObject();
	}

	IEnumerator updateText(){
		Text text = GetComponent<Text> ();
		yield return new WaitUntil(() => LocalizationManager.Instance.GetIsReady() == true);
		text.text = LocalizationManager.Instance.GetLocalizedValue (key);

	}

	public void updateObject(){
		StartCoroutine(updateText());
	}

}