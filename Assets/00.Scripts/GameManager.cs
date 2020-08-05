using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public enum ManagerState { INTRO, LOBBY, GAME }

[DefaultExecutionOrder(-2000)]
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    private SaveData saveData;

    [SerializeField]
    private ManagerState state = ManagerState.INTRO;

    [SerializeField]
    private string saveDatastring = "fandora";

    public void Save()
    {
        ES3.Save<SaveData>(saveDatastring, saveData);
    }

    public void Awake()
    {
        Screen.SetResolution(720, 1280, FullScreenMode.Windowed);
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    private void OnApplicationFocus(bool focusStatus)

    {
        if (focusStatus)

        {
            DisableSystemUI.DisableNavUI();
        }
    }

    private void Start()
    {
        try
        {
            saveData = ES3.Load<SaveData>(saveDatastring);
        }
        catch
        {
            saveData = new SaveData();
        }
    }

    private void OnApplicationQuit()
    {
        ES3.Save<SaveData>(saveDatastring, saveData);
    }

    public void NextScene(string sceneName)
    {
        ES3.Save<SaveData>(saveDatastring, saveData);
        SceneManager.LoadScene(sceneName);
    }
    
}