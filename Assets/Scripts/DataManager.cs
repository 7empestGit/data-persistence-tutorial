using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
  public static DataManager Instance;

  [HideInInspector] public string PlayerName;

  void Awake ()
  {
    if (Instance != null)
    {
      Destroy (gameObject);
      return;
    }

    Instance = this;
    DontDestroyOnLoad (gameObject);
  }

  public void SaveBestScore (SaveData saveData)
  {
    string json = JsonUtility.ToJson (saveData);

    File.WriteAllText (Application.persistentDataPath + "/savefile.json", json);
  }

  public SaveData LoadBestScore ()
  {
    string path = Application.persistentDataPath + "/savefile.json";
    SaveData data = null;

    if (File.Exists (path))
    {
      string json = File.ReadAllText (path);
      data = JsonUtility.FromJson<SaveData> (json);
    }
    else
    {
      SaveBestScore (data);
    }

    return data;
  }
}
