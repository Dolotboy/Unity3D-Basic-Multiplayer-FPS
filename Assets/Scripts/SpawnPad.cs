using UnityEngine;
using Unity.NetCode

public class SpawnPad : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject blueBall;
    [SerializeField] private GameObject redBall;
    
    void Start()
    {
        GameManager.Instance.OnIncrementScore += GameManager_OnIncrementScore;
    }

    private void GameManager_OnIncrementScore(object sender, GameManager.OnIncrementScoreEventArgs e)
    {
        Instantiate(blueBall, spawnPoint); // Instantiate the prefab/object
    }
}
