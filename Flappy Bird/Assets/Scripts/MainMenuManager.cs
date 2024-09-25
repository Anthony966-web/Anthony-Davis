using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager: MonoBehaviour
{
	public GameObject settingsUI;    
	public Toggle godModeToggle;      

	public GameObject Canvas;

	private const string GodModePrefKey = "GodMode"; // Key for PlayerPrefs to save GodMode state

	private void Start()
	{
       
		if (PlayerPrefs.HasKey(GodModePrefKey))
		{
			bool isGodMode = PlayerPrefs.GetInt(GodModePrefKey) == 1;
			godModeToggle.isOn = isGodMode;
		}
	}


	public void PlayGame()
	{
        
		SceneManager.LoadScene("Game");
	}

   
	public void OpenSettings()
	{
        
		settingsUI.SetActive(true);
	}

 
	public void CloseSettings()
	{
        
		settingsUI.SetActive(false);
	}

   
	public void QuitGame()
	{
		// Closes the game (only works in built applications, not in the Unity Editor)
		Application.Quit();

#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#endif
	}
	
	public void ResetBestScore()
	{
		Canvas.GetComponent<Score>()._highScore = 0;
		PlayerPrefs.Save();
	}

	// Called when the God Mode toggle is changed
	public void OnGodModeToggleChanged()
	{
		// Save the God Mode state in PlayerPrefs (1 = true, 0 = false)
		bool isGodMode = godModeToggle.isOn;
		PlayerPrefs.SetInt(GodModePrefKey, isGodMode ? 1 : 0);
		PlayerPrefs.Save();
	}
}

