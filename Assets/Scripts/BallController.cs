using System.Runtime.CompilerServices;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float startSpeed;

    private Rigidbody2D rb;
    private ScoreManager scoreManager; 
    private GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreManager = FindAnyObjectByType<ScoreManager>();
        gameManager = FindAnyObjectByType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GoalLeft")) // updating score and ball 
        {
            Destroy(gameObject);
            scoreManager.AddScore("right");
            scoreManager.SetScore();
            gameManager.StartBall();
        }

        if (collision.CompareTag("GoalRight"))
        {
            Destroy(gameObject);
            scoreManager.AddScore("left");
            scoreManager.SetScore();
            gameManager.StartBall();
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // set variables
            float paddleY = collision.transform.position.y; // paddle y value
            float ballY = transform.position.y; // ball y value
            float paddleHeight = collision.collider.bounds.size.y; // paddle height value
            float maxAngle = 80f * Mathf.Deg2Rad; // maximum angle value
            float direction = (rb.linearVelocity.x > 0) ? 1 : -1; // find the ball direction

            // calculate values
            float distance = (ballY - paddleY) / (paddleHeight / 2);
            float angle = distance * maxAngle;

            // set direction and speed
            Vector2 newDirection = new Vector2(Mathf.Cos(angle) * direction, Mathf.Sin(angle)); // calculate the new direction
            newDirection = newDirection.normalized;

            float speed = rb.linearVelocity.magnitude;
            rb.linearVelocity = newDirection * speed;
        }
    }
}
