using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;

    public void AddScore()
    {
        score++;
    }
}
