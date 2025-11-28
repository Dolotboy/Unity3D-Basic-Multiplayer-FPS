using UnityEngine;

public class GameVisualManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.Instance.OnIncrementScore += GameManager_OnIncrementScore;
    }

    private void GameManager_OnIncrementScore(object sender, GameManager.OnIncrementScoreEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}
