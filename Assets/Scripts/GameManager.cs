using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    private int startSpeed = 200;

    void Start()
    {
        StartBall();
    }

    public void StartBall()
    {
        GameObject ball = Instantiate(ballPrefab);
        ball.GetComponent<Rigidbody2D>().AddForce(Vector2.left * startSpeed);
    }
}
