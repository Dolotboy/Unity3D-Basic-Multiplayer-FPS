using UnityEngine;
using UnityEngine.InputSystem;

public class Clicker : MonoBehaviour
{
    private PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls();
    }

    void OnEnable()
    {
        controls.Player.Attack.Enable();
    }

    void OnDisable()
    {
        controls.Player.Attack.Disable();
    }

    void Update()
    {
        if (controls.Player.Attack.triggered)
        {
            //Debug.Log("Attack triggered !");
            GameManager.Instance.IncrementScore();
        }
    }
}
