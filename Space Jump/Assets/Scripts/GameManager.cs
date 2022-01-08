using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public TextMeshProUGUI scoreText;
	public Button playAgain;
	public Button mainMenu;

	public static GameManager instance;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void AddScore(int camPos)
	{
		scoreText.text = camPos.ToString();
	}

	public void LoseGame()
	{
		playAgain.gameObject.SetActive(true);
		mainMenu.gameObject.SetActive(true);
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
