using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainDataManager : MonoBehaviour
{


    // Start is called before the first frame update

    public static MainDataManager Instance;

    public string userName;
    public int bestScore;
    public string nameTheBest;

    private void Awake()
    {

        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadScore();
    }

    [System.Serializable]
    class SaveData
    {
        public int bestScore;
        public string nameTheBest;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.bestScore = bestScore;
        data.nameTheBest = nameTheBest;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScore = data.bestScore;
            nameTheBest = data.nameTheBest;
        }
    }

}
