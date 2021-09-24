using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour {

    private void Awake() {

        transform.Find("playbtn").GetComponent<Button>().onClick.AddListener(() => {
            GameSceneManager.Load(GameSceneManager.Scene.GameScene);
        });
        transform.Find("quitbtn").GetComponent<Button>().onClick.AddListener(() => {
            Application.Quit();
        });
        transform.Find("howtoplaybtn").GetComponent<Button>().onClick.AddListener(() => {
            GameSceneManager.Load(GameSceneManager.Scene.HowToPlay);
        });
        transform.Find("creditsbtn").GetComponent<Button>().onClick.AddListener(() => {
            GameSceneManager.Load(GameSceneManager.Scene.Credits);
        });

    }
    
}
