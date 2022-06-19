using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

}
