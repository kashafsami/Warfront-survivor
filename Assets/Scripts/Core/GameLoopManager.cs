using UnityEngine;

public class GameLoopManager : MonoBehaviour
{
    public bool isGameOver = false;

    void Start()
    {
        // Game initialization logic for Warfront Survivor
        Debug.Log("Warfront Survivor: Sprint 1 Core Core Loop Initialized.");
        isGameOver = false;
    }

    void Update()
    {
        if (isGameOver)
        {
            // Future placeholder for Sprint 3 (Disqualification or Defeat)
            Time.timeScale = 0f;
        }
    }
}
