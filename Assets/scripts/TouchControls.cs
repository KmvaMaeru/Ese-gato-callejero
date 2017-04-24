using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {

	private control thePlayer;
	private TextBoxManager theTexts;
	private LevelLoader levels;
	private Pausa pauseMenu;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<control>();
		theTexts = FindObjectOfType<TextBoxManager>();
		levels = FindObjectOfType<LevelLoader>();
		pauseMenu = FindObjectOfType<Pausa>();

	}
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

}
