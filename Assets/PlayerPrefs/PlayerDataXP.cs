using System.Collections;
using UnityEngine;
using Gamekit3D;
using Assets._3DGamekit.Scripts.HealthBar;


namespace Assets.PlayerPrefs
{
    [System.Serializable]
    public class PlayerDataXP
    {
        public int level;
        public float currentXP;
        public int killCOunt;

        public PlayerDataXP (XPBar xPBar)
        {
            level = xPBar.level;
            currentXP = xPBar.currentXP;
            killCOunt = xPBar.killcount;
        }
    }
}