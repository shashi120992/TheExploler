using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Gamekit3D;
using Assets._3DGamekit.Scripts.HealthBar;

namespace Assets.PlayerPrefs
{
    public static class SavePlayerData
    {
        public static void savePlayer(XPBar xPBar, PlayerHealth playerHealth, PlayerController playerController)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/Player.SaveData";

            FileStream stream = new FileStream(path, FileMode.Create);
            PlayerData data = new PlayerData(xPBar, playerHealth, playerController);
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static PlayerData loadPlayer()
        {
            string path = Application.persistentDataPath + "/Player.SaveData";

            if(File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerData data = formatter.Deserialize(stream) as PlayerData;
                stream.Close();

                return data;

            }
            else
            {
                Debug.LogError("file Not Found");
                return null;
            }
        }
    }
}