using UnityEngine.Events;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public int lives = 5;

    public TMP_Text scoreText;
    public TMP_Text livesText;
    public TMP_Text gameOverText; 

    private void Start()
    {
        UpdateHUD();
        
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void AddPoints(int quantidade)
    {
        score += quantidade;
        UpdateHUD();
    }

    public void RemoveLife()
    {
        
        if (lives <= 0)
        {
            Debug.Log("Game Over! (Já estava)");
            return;
        }

        lives--; 
        if (lives <= 0)
        {
            Debug.Log("Game Over! Vidas chegaram a zero.");
            
            if (gameOverText != null)
            {
                gameOverText.gameObject.SetActive(true);
            }
           
        }

        UpdateHUD(); 
    }

    public void Heal()
    {
        
        if (lives >= 5)
        {
            return;
        }

        lives++;
        UpdateHUD();
    }

    public void UpdateHUD()
    {
        scoreText.text = "Pontos: " + score;
        livesText.text = "Vidas: " + lives;
    }
}