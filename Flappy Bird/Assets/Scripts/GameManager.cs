using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	[SerializeField] private GameObject _gameOverCanvas;
	
	public GameObject MenuCanvas;
	public GameObject PauseMenu;
	
	public GameObject player;
	public GameObject scoreCanvas;
	public GameObject scoreTXT;
	
	public GameObject pipeSpawner;
	
	private const string GodModePrefKey = "GodMode"; // Same key used for God Mode

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		Time.timeScale = 1f;
	}
	
	public void GameOver()
	{
		_gameOverCanvas.SetActive(true);
		MenuCanvas.SetActive(false);
		Time.timeScale = 0f;
	}
	
	public void RestartGame()
	{
		pipeSpawner.GetComponent<PipeSpawner>()._maxTime = 4.5f;
		pipeSpawner.GetComponent<PipeSpawner>()._pipe.GetComponent<MoveLeft>()._speed = 3f;
		
		scoreCanvas.GetComponent<Score>()._score = 0;
		scoreTXT.GetComponent<Text>().text = "0";
		
		MenuCanvas.SetActive(true);
		PauseMenu.SetActive(false);
		
		GameObject[] pipes = GameObject.FindGameObjectsWithTag("Column");
  foreach(GameObject pipe in pipes)
	  GameObject.Destroy(pipe);
		
		player.GetComponent<Transform>().transform.position = new Vector3(-9, 0, 0);
		_gameOverCanvas.SetActive(false);
		Time.timeScale = 1f;
		//SceneManager.LoadScene("Game");
	}

	private void Start()
	{
		// Check if God Mode is enabled
		bool isGodMode = PlayerPrefs.GetInt(GodModePrefKey, 0) == 1;

		if (isGodMode)
		{
			EnableGodMode();
		}
		else
		{
			Debug.Log("God Mode Disabled!");
		}
	}

	private void EnableGodMode()
	{
		// Logic to enable God Mode in the game
		Debug.Log("God Mode Enabled!");
		player.GetComponent<Movement>().canDie = false;
		// Example: Give the player invincibility or other powers
	}
}
