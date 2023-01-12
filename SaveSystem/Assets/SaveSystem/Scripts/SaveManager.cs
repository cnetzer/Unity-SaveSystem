using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

// ReSharper disable All

namespace SaveSystem
{
    public static class SaveManager
    {
        public static void Save(SaveData data, string path, bool useEncryption)
        {
            var formatter = new BinaryFormatter();
            var stream = new FileStream(Path.Combine(Application.persistentDataPath, path), FileMode.Create,
                FileAccess.Write);

            var json = JsonUtility.ToJson(data);
            formatter.Serialize(stream, json);
            stream.Close();
        }

        public static void Load()
        {
            
        }
    }
}