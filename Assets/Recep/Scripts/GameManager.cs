using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance; 
    public TextMeshProUGUI scoreText; 
    private int score = 0; 

    void Awake()
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

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        Debug.Log("Game Over! Final Score: " + score);
    }
}
