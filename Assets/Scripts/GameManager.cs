using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;} // Singleton

    private int score = 0;

    public event EventHandler<OnIncrementScoreEventArgs> OnIncrementScore;
    public class OnIncrementScoreEventArgs : EventArgs
    {
        public int score;
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one GameManager instance !");
        }
        Instance = this;
    }

    public void IncrementScore()
    {
        score += 1;
        Debug.Log("New score : " + score.ToString());
        OnIncrementScore?.Invoke(this, new OnIncrementScoreEventArgs{score = score,});
    }
}
