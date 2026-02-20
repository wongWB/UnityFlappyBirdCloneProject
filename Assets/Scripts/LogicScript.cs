using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject pauseMenuScreen;
    public BirdScript bird;
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }


    public void addScore(int scoreToAdd)
    {
        if (bird.birdIsAlive)
        {
            playerScore+= scoreToAdd;
            scoreText.text = playerScore.ToString(); 
        }
    }

    public void restartScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Time.timeScale = 1f;

    }
    public void returnToMenu()
    {
        SceneManager.LoadScene("SceneMenu");
    }    
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void pauseScreen()
    {
        pauseMenuScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resume() 
    {
        pauseMenuScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}
