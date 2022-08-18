using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Gamekit3D;
using Assets._3DGamekit.Scripts.HealthBar;

namespace Assets.PlayerPrefs
{
    public static class SavePlayerDataHealth
    {

        public static void savePlayerHealth(PlayerHealth playerHealth)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/Player.SaveDataHealth";

            FileStream stream = new FileStream(path, FileMode.Create);
            PlayerDataHealth data = new PlayerDataHealth(playerHealth);
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static PlayerDataHealth loadPlayerHealth()
        {
            string path = Application.persistentDataPath + "/Player.SaveDataHealth";

            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerDataHealth data = formatter.Deserialize(stream) as PlayerDataHealth;
                stream.Close();

                return data;

            }
            else
            {
                Debug.LogError("file Health Not Found");
                return null;
            }
        }
    }
}