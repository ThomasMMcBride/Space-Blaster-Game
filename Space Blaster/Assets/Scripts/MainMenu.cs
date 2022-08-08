using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

// loads the next scene
public void startGame() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
}
