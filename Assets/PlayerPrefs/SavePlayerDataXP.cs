using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Gamekit3D;
using Assets._3DGamekit.Scripts.HealthBar;

namespace Assets.PlayerPrefs
{
    public static class SavePlayerDataXP
    {

        public static void savePlayerXP (XPBar xPBar)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/Player.SaveDataXP";

            FileStream stream = new FileStream(path, FileMode.Create);
            PlayerDataXP data = new PlayerDataXP(xPBar);
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static PlayerDataXP loadPlayerXP()
        {
            string path = Application.persistentDataPath + "/Player.SaveDataXP";

            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerDataXP data = formatter.Deserialize(stream) as PlayerDataXP;
                stream.Close();

                return data;

            }
            else
            {
                Debug.LogError("fileXP Not Found");
                return null;
            }
        }
    }
}