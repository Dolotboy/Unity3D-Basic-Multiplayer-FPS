using UnityEngine;
using Unity.Netcode;

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
        // Instantiate the prefab/object
        GameObject obj = Instantiate(blueBall, spawnPoint.position, spawnPoint.rotation); 

        
        NetworkObject netObj = obj.GetComponent<NetworkObject>();

        if (netObj == null)
        {
            Debug.LogError("Le prefab blueBall n'a PAS de NetworkObject !");
            return;
        }

        // This is the reason why we keep the transform of the instantiated object, it's to spawn it on the network too
        netObj.Spawn(true);
    }
}
