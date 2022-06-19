using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{

    public string userName;
    public GameObject inputField;
    public Text BestScoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnEnable()
    {
        BestScoreText.text = "Best Score : " + MainDataManager.Instance.nameTheBest + ": " + MainDataManager.Instance.bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        userName = inputField.GetComponent<Text>().text;
        MainDataManager.Instance.userName = userName;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
