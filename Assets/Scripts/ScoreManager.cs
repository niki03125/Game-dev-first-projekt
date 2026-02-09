using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int homeScore = 0;
    public int awayScore = 0;
    
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    
    public void AddHomePoint()
    {
        homeScore++;
        UpdateScoreText();
    }
    
    public void AddAwayPoint()
    {
        awayScore++;
        UpdateScoreText();
    }
    
    
    void UpdateScoreText()
    {
        scoreText.text = homeScore + " - " + awayScore;
    }
}
