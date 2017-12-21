using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveModel : MonoBehaviour {
	public float Speed = 10f;

	public float Timer = 10f;

	private float _deltaTime = 0f;

	private Vector3 _startPosition;
	private Vector3 _forward;
	
	// Use this for initialization
	void Start()
	{
		_startPosition = transform.position;
		_forward = transform.forward;
	}
	
	// Update is called once per frame
	void Update ()
	{
		MoveObject();
		Timing();
	}

	void MoveObject()
	{
		transform.position += transform.forward * Speed * Time.deltaTime;
	}

	void Timing()
	{
		_deltaTime += Time.deltaTime;
		if (_deltaTime >= Timer)
		{
			transform.position = _startPosition;
			_deltaTime = 0;
		}
	}
}
