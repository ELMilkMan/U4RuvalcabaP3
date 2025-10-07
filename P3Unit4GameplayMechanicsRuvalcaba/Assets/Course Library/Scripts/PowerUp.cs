using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum PowerUpType { None, Pushback, Rockets }

    public PowerUpType powerUpType; // holds which type this power-up is

    void Start()
    {
        // Optional: you could initialize something here if needed
    }

    void Update()
    {
        // Optional: spin the power-up, or make it move, etc.
    }
}

