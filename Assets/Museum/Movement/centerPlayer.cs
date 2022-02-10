using UnityEngine;
using System.Collections;

public class centerPlayer : MonoBehaviour {


	public GameObject player;
	private float playerMoveSpeed = 4f;
	public GameObject eventSystem;
	public GameObject centerWaypoint;

	[Space(10)]

	public GameObject entranceScreens;
	public GameObject contentStations;
	public GameObject waypoints;



	void Start() {
		entranceScreens = GameObject.Find("Entrance Screens");
		//contentStations = GameObject.Find("Info and Video Screens");
		//waypoints = GameObject.Find("Waypoints");
	}


	public void Begin() {

		iTween.MoveTo (player, centerWaypoint.transform.position, playerMoveSpeed);

		entranceScreens.SetActive(false);
		waypoints.SetActive(true);
		contentStations.SetActive (true);
	}
}	