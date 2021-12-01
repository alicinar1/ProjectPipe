using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] private CanvasGroup gameOverCanvas;
    [SerializeField] private CanvasGroup pauseGameCanvas;
    [SerializeField] private CanvasGroup inGameCanvas;
    [SerializeField] private ObstacleSpawner obstacleSpawner;
    [SerializeField] private Button pauseButton;
    [SerializeField] private TMP_Text gameOverScoreText;
    [SerializeField] private TMP_Text gameOverHighScoreText;

    private int highScore;
    

    private int score;
    private bool isSpeedIncreased = false;
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");        
    }

    public void PauseGame()
    {
        PauseCanvas();
        Time.timeScale = 0;
        if (pauseGameCanvas.alpha == 1)
        {
            Time.timeScale = 0;
        }
    }
    
    public void PauseCanvas()
    {
        obstacleSpawner.enabled = false;
        pauseButton.enabled = false;
        pauseGameCanvas.gameObject.SetActive(true);
        StartCoroutine(CanvasFadeOut(inGameCanvas));
    }

    public void ResumeGame()
    {
        obstacleSpawner.enabled = true;
        pauseButton.enabled = true;
        StartCoroutine(CanvasFadeIn(inGameCanvas));
        pauseGameCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        obstacleSpawner.enabled = false;
        Player.Instance.PlayerMovementSpeed = 0;
        Player.Instance.gameObject.GetComponentInChildren<InputController>().enabled = false;
        gameOverCanvas.gameObject.SetActive(true);
        gameOverScoreText.text = "Score: " + CalculateScore().ToString();
        gameOverHighScoreText.text = "High Score: " + PlayerPrefs.GetInt("highscore");
        StartCoroutine(CanvasFadeOut(inGameCanvas));
        StartCoroutine(CanvasFadeIn(gameOverCanvas));
    }

    IEnumerator CanvasFadeIn(CanvasGroup canvas)
    {
        float counter = 0f;

        while (canvas.alpha < 1)
        {
            counter += Time.deltaTime;
            canvas.alpha = Mathf.Lerp(0f, 1f, counter * 4);

            yield return null;
        }
    }
    IEnumerator CanvasFadeOut(CanvasGroup canvas)
    {
        float counter = 1f;

        while (canvas.alpha > 0)
        {
            counter += Time.deltaTime;
            canvas.alpha = Mathf.Lerp(1f, 0f, counter);

            yield return null;
        }
    }
    public void IncreasePlayerSpeed()
    {
        Player.Instance.PlayerMovementSpeed++;
        Debug.Log("!!!!!!!!!!" + Player.Instance.PlayerMovementSpeed);
    }

    public int CalculateScore()
    {
        score = Mathf.RoundToInt(Player.Instance.transform.position.z * 0.1f);

        if (score > highScore)
        {
            highScore = score;

            PlayerPrefs.SetInt("highscore", highScore);
        }

        if (score % 20 == 0 && !isSpeedIncreased)
        {
            IncreasePlayerSpeed();
            isSpeedIncreased = true;
        }
        else if (!(score % 20 == 0))
        {
            isSpeedIncreased = false;
        }
        

        return score;
    }

    
}
