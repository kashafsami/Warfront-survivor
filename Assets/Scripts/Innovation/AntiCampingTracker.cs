using UnityEngine;

public class AntiCampingTracker : MonoBehaviour
{
    private Vector2 lastPosition;
    public float campingTimer = 0f;
    public float maxAllowedCampingTime = 10f; // 10 seconds stationary limit
    public float thresholdDistance = 0.5f;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        // Distance check between frames
        float distanceMoved = Vector2.Distance(transform.position, lastPosition);

        if (distanceMoved < thresholdDistance)
        {
            campingTimer += Time.deltaTime;
            if (campingTimer >= maxAllowedCampingTime)
            {
                TriggerDisqualification();
            }
        }
        else
        {
            campingTimer = 0f; // Reset if player moves
            lastPosition = transform.position;
        }
    }

    void TriggerDisqualification()
    {
        Debug.Log("Player Disqualified! Reason: Passive Camping Detected.");
        // Game Over logic triggers here
    }
}
