using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour {

    public enum Scene {
        GameScene,
        MainMenuScene,
        HowToPlay,
        Credits,
    }
    public static void Load(Scene scene) {
        SceneManager.LoadScene(scene.ToString());
    }
}
