using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
	[SerializeField] public float _speed = 3f; //0.65f
	
	private void Update()
	{
		transform.position += Vector3.left *_speed * Time.deltaTime;
	}
}
