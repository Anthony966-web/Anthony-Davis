using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public bool isPaused = false;
	public KeyCode pauseKey = KeyCode.Escape;
	public GameObject pauseMenu;
	public GameObject CharacterMenu;

	public GameObject yellowBird;
	public GameObject redBird;
	public GameObject purpleBird;
	public GameObject blueBird;
	
	public GameObject yellowBirdUI;
	public GameObject redBirdUI;
	public GameObject purpleBirdUI;
	public GameObject blueBirdUI;
	
	public GameObject scoreCanvas;
	
	public GameObject GodMenu;
	public GameObject player;
	
	public GameObject MenuCanvas;
	
	// Start is called before the first frame update
	void Start()
	{
        
	}

	// Update is called once per frame
	void Update()
	{
		if(MenuCanvas.active == false)
		{
			isPaused = false;
		}
		
		if (Input.GetKeyDown(pauseKey))
		{
			isPaused = !isPaused;
			Debug.Log("Paused: " + isPaused);

            
			if (isPaused)
			{
				Time.timeScale = 0f;
				if (player.GetComponent<Movement>().canDie == false)
				{
					GodMenu.SetActive(true);
				}
				pauseMenu.SetActive(true);
			}
			else
			{
				Time.timeScale = 1f;
				CharacterMenu.SetActive(false);
				pauseMenu.SetActive(false);

			}
		}
		
		if (yellowBird.active == true)
		{
			yellowBirdUI.GetComponent<Text>().text = "Equiped";
		}
		if (yellowBird.active == false)
		{
			yellowBirdUI.GetComponent<Text>().text = "Equip";
		}
		
		if (redBird.active == true)
		{
			redBirdUI.GetComponent<Text>().text = "Equiped";
		}
		if (redBird.active == false)
		{
			redBirdUI.GetComponent<Text>().text = "Equip";
		}
		
		if (purpleBird.active == true)
		{
			purpleBirdUI.GetComponent<Text>().text = "Equiped";
		}
		if (purpleBird.active == false)
		{
			purpleBirdUI.GetComponent<Text>().text = "Equip";
		}
		
		if (blueBird.active == true)
		{
			blueBirdUI.GetComponent<Text>().text = "Equiped";
		}
		if (blueBird.active == false)
		{
			blueBirdUI.GetComponent<Text>().text = "Equip";
		}
		
	}

	public void Continue()
	{
		Time.timeScale = 1f;
		isPaused = false;
		pauseMenu.SetActive(false);
	}

	public void MainMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("MainMenu");
	}

	public void OpenCharacterMenu()
	{
		CharacterMenu.SetActive(true);
	}

	public void CloseCharacterMenu()
	{
		CharacterMenu.SetActive(false);
	}

	public void YellowBird()
	{	
		yellowBird.SetActive(true);
		redBird.SetActive(false);
		purpleBird.SetActive(false);
		blueBird.SetActive(false);
	}

	public void RedBird()
	{
		if(scoreCanvas.GetComponent<Score>()._highScore >= 5)
		{
			yellowBird.SetActive(false);
			redBird.SetActive(true);
			purpleBird.SetActive(false);
			blueBird.SetActive(false);
		}
	}

	public void PurpleBird()
	{
		if(scoreCanvas.GetComponent<Score>()._highScore >= 30)
		{
			yellowBird.SetActive(false);
			redBird.SetActive(false);
			purpleBird.SetActive(true);
			blueBird.SetActive(false);
		}
	}

	public void BlueBird()
	{
		if(scoreCanvas.GetComponent<Score>()._highScore >= 15)
		{
			yellowBird.SetActive(false);
			redBird.SetActive(false);
			purpleBird.SetActive(false);
			blueBird.SetActive(true);
		}
	}
}
