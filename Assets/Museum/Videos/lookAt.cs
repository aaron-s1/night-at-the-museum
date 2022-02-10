using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour {


	//public Transform thecamera;
	
	public Camera m_Camera;



	void Start () {
		m_Camera = Camera.main;
	}

	void Update () {
		if (gameObject.activeSelf == true)
		{
			gameObject.transform.rotation = Quaternion.LookRotation(gameObject.transform.position - m_Camera.transform.position);
		}

		//transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
		//		m_Camera.transform.rotation * Vector3.up);	
		// transform.LookAt(thecamera);

	}
}
