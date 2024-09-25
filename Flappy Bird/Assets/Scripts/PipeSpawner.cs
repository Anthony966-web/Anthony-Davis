using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
	[SerializeField] public float _maxTime = 4.5f; //1.5
	[SerializeField] private float _hightRange = 0.5f; //0.45
	[SerializeField] public GameObject _pipe;
	
	public GameObject ScoreCanvas;
	public GameObject pipeSpawner;
	
	private float _timer;
	
    // Start is called before the first frame update
	private void Start()
    {
	    SpawnPipe();
    }

    
	private void Update()
	{
		if (_timer > _maxTime)
		{
			SpawnPipe();
			_timer = 0;
		}
		_timer += Time.deltaTime;
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 5)
		{
			_maxTime = 4.09f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 3.75f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 10)
		{
			_maxTime = 3.71f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 4.25f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 15)
		{
			_maxTime = 3.38f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 5f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 20)
		{
			_maxTime = 3.07f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 6f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 25)
		{
			_maxTime = 2.79f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 7f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 30)
		{
			_maxTime = 2.53f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 8f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 35)
		{
			_maxTime = 2.30f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 9f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 40)
		{
			_maxTime = 2.09f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 10f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 45)
		{
			_maxTime = 1.90f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 12f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 50)
		{
			_maxTime = 1.73f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 15f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 55)
		{
			_maxTime = 1.57f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 17.5f;
		}
		
		if(ScoreCanvas.GetComponent<Score>()._score >= 60)
		{
			_maxTime = 1.43f;
			pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 20.5f;
		}
	}
    
	private void SpawnPipe()
    {
	    Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_hightRange, _hightRange));
	    GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);
	    
	    Destroy(pipe, 8.3f);
    }
}
