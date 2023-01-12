using SaveSystem;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private void Start()
    {
        SaveManager.Save(new SaveData(), "save.json", false);
    }
}
