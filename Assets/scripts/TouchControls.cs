using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchControls : MonoBehaviour {

	private control thePlayer;
	private TextBoxManager theTexts;
	private LevelLoader levels;
	private Pausa pauseMenu;
	public GameObject touchControls;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<control>();
		theTexts = FindObjectOfType<TextBoxManager>();
		levels = FindObjectOfType<LevelLoader>();
		pauseMenu = FindObjectOfType<Pausa>();

		#if UNITY_STANDALONE

		touchControls.SetActive (false);

		#endif
	}


	#if UNITY_ANDROID



	public void LeftArrow()
	{
		thePlayer.Move(-1);
	}
	public void RightArrow()
	{
		thePlayer.Move(1);
	}
	public void UnpressedArrow()
	{
		thePlayer.Move(0);
	}
	public void Dash()
	{
		thePlayer.Dash();
	}
	public void ResetDash()
	{
		thePlayer.ResetDash();
	}
	public void Jump()
	{
		thePlayer.Jump();
	}
	public void Submit()
	{
		theTexts.Submit();
	}
	public void LoadLevel()
	{
		if (levels.playerInZone)
		{
		levels.LoadLevel();
		}
	}
	public void Pause()
	{
		pauseMenu.PauseUnpaused();
	}
		#endif
}
