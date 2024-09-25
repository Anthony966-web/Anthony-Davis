using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public static Score instance;
	
	[SerializeField] private Text _currentScoreText;
	[SerializeField] private Text _highScoreText;
	
	public int _score;
	public int _highScore;
	
	public GameObject Player;
	public GameObject GodModeScore;
	
	private void Awake()
    {
	    if (instance == null)
	    {
	    	instance = this;
	    }
    }

	public void Update()
	{
		_highScoreText.text = _highScore.ToString();
		_currentScoreText.text = _score.ToString();
		PlayerPrefs.SetInt("HighScore", _highScore);
	}
	
	private void Start()
    {
	    _currentScoreText.text = _score.ToString();
	    _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
	    _highScore = PlayerPrefs.GetInt("HighScore", 0);
	    UpdateHighScore();
    }
    
	private void UpdateHighScore()
	{
		if(Player.GetComponent<Movement>().canDie == true)
		{
			if (_score > PlayerPrefs.GetInt("HighScore"))
			{
				PlayerPrefs.SetInt("HighScore", _score);
				_highScoreText.text = _score.ToString();
				_highScore = _score;
			}
		}
	}
	
	public void GodModeScoreValue()
	{
		if(Player.GetComponent<Movement>().canDie == false)
		{
			_score = System.Convert.ToInt32(GodModeScore.GetComponent<InputField>().text);
		}
	}
	
	public void UpdateScore()
	{
		_score++;
		_currentScoreText.text = _score.ToString();
		UpdateHighScore();
	}
}
