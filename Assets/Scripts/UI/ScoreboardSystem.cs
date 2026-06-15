using UnityEngine;

public class ScoreboardSystem : MonoBehaviour
{
    public int totalScore = 0;
    public int enemyKills = 0;
    public int missionsCompleted = 0;

    public void CalculateFinalScore()
    {
        // Innovation Scoring Meta: Score handles kills and completed missions
        totalScore = (enemyKills * 10) + (missionsCompleted * 50);
        Debug.Log("Final Calculated Scoreboard Points: " + totalScore);
    }
}
