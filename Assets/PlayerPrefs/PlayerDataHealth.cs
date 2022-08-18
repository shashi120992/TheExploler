using System.Collections;
using UnityEngine;
using Gamekit3D;
using Assets._3DGamekit.Scripts.HealthBar;

namespace Assets.PlayerPrefs
{
    [System.Serializable]
    public class PlayerDataHealth
    {
        public float health;
        
        public PlayerDataHealth (PlayerHealth playerHealth)
        {
            health = playerHealth.health;
        }
    }
}