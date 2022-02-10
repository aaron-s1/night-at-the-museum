using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {


	public GameObject player;
	public GameObject moveForward;
	public GameObject eventSystem;

	private GameObject startButton;

	[Space(10)]
	private float playerMoveSpeed = 4f;

	void Start() {
		startButton = GameObject.Find("Start Button");
	}


	public void Begin() { 
		iTween.MoveTo (player, moveForward.transform.position, playerMoveSpeed);
		startButton.SetActive(false);
	}

}	