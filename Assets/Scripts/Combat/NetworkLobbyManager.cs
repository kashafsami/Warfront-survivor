using UnityEngine;
using System.Collections.Generic;

public class NetworkLobbyManager : MonoBehaviour
{
    public const int MAX_PLAYERS = 50; // Strict limit for 50-player capacity
    public List<string> activePlayersList = new List<string>();

    void Start()
    {
        Debug.Log("Multiplayer Network Server Initialized for 50 Players Capacity.");
    }

    public bool JoinLobby(string playerID)
    {
        if (activePlayersList.Count < MAX_PLAYERS)
        {
            activePlayersList.Add(playerID);
            Debug.Log(playerID + " connected successfully to micro-battlefield.");
            return true;
        }
        else
        {
            Debug.Log("Lobby Full! Matchmaking cannot exceed 50 concurrent connections.");
            return false;
        }
    }
}
