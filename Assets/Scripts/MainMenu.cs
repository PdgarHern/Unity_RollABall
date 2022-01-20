using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame() {
    SceneManager.LoadScene(1);

  }

  public void Continue() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

  }

  public void LevelSelector() {
    SceneManager.LoadScene(4);

  }

  public void Level2() {
    SceneManager.LoadScene(2);

  }

  public void Level3() {
    SceneManager.LoadScene(3);

  }

  public void QuitGame() {
    Debug.Log("QUIT!");
    Application.Quit();

  }

  public void Retry() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

  }

  public void BackToMenu() {
    SceneManager.LoadScene(0);

  }

}
