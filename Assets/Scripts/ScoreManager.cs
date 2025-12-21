using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreLeftText;
    public TMP_Text scoreRightText;
    public int scoreLeft;
    public int scoreRight;

    public void AddScore(string value)
    {
        switch (value)
        {
            case "left":
                scoreLeft++;
                break;
            case "right":
                scoreRight++;
                break;
        }
    }

    public void SetScore()
    {
        scoreLeftText.text = scoreLeft.ToString();
        scoreRightText.text = scoreRight.ToString();
    }
}
