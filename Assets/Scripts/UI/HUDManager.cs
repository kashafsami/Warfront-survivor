using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public int playerHealth = 100;
    public int ammoCount = 30;

    void OnGUI()
    {
        // 2D UI Elements screen par display karne ke liye
        GUI.Box(new Rect(10, 10, 150, 90), "Warfront Status");
        GUI.Label(new Rect(20, 40, 130, 20), "Health: " + playerHealth);
        GUI.Label(new Rect(20, 60, 130, 20), "Ammo: " + ammoCount);
    }

    public void UpdateHUD(int health, int ammo)
    {
        playerHealth = health;
        ammoCount = ammo;
    }
}
