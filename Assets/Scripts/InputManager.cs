using UnityEngine;

public class InputManager : MonoBehaviour
{
    GameManager gameManager;

    void Start() => gameManager = GetComponent<GameManager>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameManager.StartBall();
        }
    }
}
