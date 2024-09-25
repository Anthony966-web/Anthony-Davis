using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
	[SerializeField] private float _velocity = 1.5f;
	[SerializeField] private float _rotationSpeed = 10f;
	
	public bool canDie = true;
	
	public Rigidbody2D _rb;
	
	public GameObject player;
	
	private void start()
	{
		_rb = GetComponent<Rigidbody2D>();
	}
	
	private void Update()
	{
		if (player.name == "Player")
		{
			if(player.GetComponent<PauseMenu>().isPaused == false)
			{
				if (Mouse.current.leftButton.wasPressedThisFrame)
				{
					_rb.velocity = Vector2.up * _velocity;
				}
			}
		}
	}
	
	private void FixedUpdate()
	{
		transform.rotation = Quaternion.Euler(0,0, _rb.velocity.y * _rotationSpeed);
	}
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			if (canDie == true)
			{
				GameManager.instance.GameOver();
			}
		}
		
		if (collision.gameObject.CompareTag("Pipe"))
		{
			if (canDie == true)
			{
				GameManager.instance.GameOver();
			}
		}
	}
}
