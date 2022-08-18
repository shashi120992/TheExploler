using System.Collections;
using UnityEngine;
using Gamekit3D;
using Assets._3DGamekit.Scripts.HealthBar;

namespace Assets.PlayerPrefs
{
    [System.Serializable]
    public class PlayerDataCtrlr
    {
        public float[] position;

        public PlayerDataCtrlr (PlayerController playerController)
        {
            position = new float[3];
            position[0] = playerController.transform.position.x;
            position[1] = playerController.transform.position.y;
            position[2] = playerController.transform.position.z;
        }
    }
}