using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class But_MainM : MonoBehaviour
{
    public int LevelNumber;
    private void Start()
    {
        //SceneName = "Start Menu";
    }

    // Start is called before the first frame update
    public void Load_Setting()
    {
        SceneManager.LoadScene("Settings");

    }
     public void Load_ChooseMenu() {
        SceneManager.LoadScene("choseMenu");

    }
    public void Load_Level() {
        SceneManager.LoadScene(LevelNumber);
        
    // SceneName = "Load_level_(int)"
    }

    public void Load_StartMenu() {

     //   SceneName = "Start Menu";
        SceneManager.LoadScene("Start Menu");

    }


}
