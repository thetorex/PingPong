using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float moveSpeed;
    public KeyCode upKey;
    public KeyCode downKey;

    void Update()
    {
        // up the racket
        if (Input.GetKey(upKey))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        }

        // down the racket
        if (Input.GetKey(downKey))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
        }
    }

}
