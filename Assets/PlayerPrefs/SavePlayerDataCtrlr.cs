using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Gamekit3D;
using Assets._3DGamekit.Scripts.HealthBar;

namespace Assets.PlayerPrefs
{
    public static class SavePlayerDataCtrlr
    {

        public static void savePlayerCtrlr(PlayerController playerController)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/Player.SaveDataCtrlr";

            FileStream stream = new FileStream(path, FileMode.Create);
            PlayerDataCtrlr data = new PlayerDataCtrlr(playerController);
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static PlayerDataCtrlr loadPlayerCtrlr()
        {
            string path = Application.persistentDataPath + "/Player.SaveDataCtrlr";

            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerDataCtrlr data = formatter.Deserialize(stream) as PlayerDataCtrlr;
                stream.Close();

                return data;

            }
            else
            {
                Debug.LogError("file Ctrlr Not Found");
                return null;
            }
        }
    }
}