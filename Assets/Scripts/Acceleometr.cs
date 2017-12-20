using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleometr : MonoBehaviour
{
	private Vector3 acDir;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		acDir = transform.position;
	}

	private void OnGUI()
	{
		GUI.Box(new Rect(0, 0, 100, 30), acDir.ToString());
	}
}
