using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashFade : MonoBehaviour {

	public Text splashText;
	public string loadLevel;

	IEnumerator Start()
	{
		splashText.canvasRenderer.SetAlpha(0.0f);

		FadeIn();
		yield return new WaitForSeconds(5.5f);
		FadeOut();
		yield return new WaitForSeconds(2.5f);
		Application.LoadLevel(loadLevel);
	}

	void FadeIn()
	{
		splashText.CrossFadeAlpha(1.0f, 1.5f, false);
	}

	void FadeOut()
	{
		splashText.CrossFadeAlpha(0.0f, 2.5f, false);
	}
}
