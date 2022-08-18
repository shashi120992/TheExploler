using System.Collections;
using UnityEngine;
using Gamekit3D;
using Assets._3DGamekit.Scripts.HealthBar;

namespace Assets.PlayerPrefs
{
    [System.Serializable]
    public class PlayerData
    {
        public int level;
        public float health;
        public float[] position;
        public float currentXP;
        public int killCOunt;

        public PlayerData (XPBar xPBar, PlayerHealth playerHealth, PlayerController playerController)
        {
            level = xPBar.level;
            health = playerHealth.health;
            currentXP = xPBar.currentXP;
            killCOunt = xPBar.killcount;

            position = new float[3];
            position[0] = playerController.transform.position.x;
            position[1] = playerController.transform.position.y;
            position[2] = playerController.transform.position.z;
        }

    }
}