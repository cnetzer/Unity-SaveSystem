using System;
using UnityEngine;

// ReSharper disable All

namespace SaveSystem
{
    [Serializable]
    public class SaveData
    {
        public int Integer;
        public float Float;
        public string String;
        public Vector3 Vector3;

        public SaveData()
        {
            Integer = 0;
            Float = 0f;
            String = "";
            Vector3 = new Vector3();
        }
    }
}