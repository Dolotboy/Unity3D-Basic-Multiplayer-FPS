using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        GameManager.Instance.OnIncrementScore += GameManager_OnIncrementScore;
        
        // init text
        //scoreText.text = "0";
    }

    private void GameManager_OnIncrementScore(object sender, GameManager.OnIncrementScoreEventArgs e)
    {
        scoreText.text = "Score : " + e.score.ToString();
    }
}
