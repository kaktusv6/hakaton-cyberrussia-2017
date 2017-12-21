using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleometr : MonoBehaviour
{
	public GameObject Target;

	private Vector3 _distance;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		_distance = Target.transform.position - transform.position;
	}

	private void OnGUI()
	{
		GUI.Box(new Rect(0, 0, 100, 30), _distance.magnitude.ToString());
	}
}
