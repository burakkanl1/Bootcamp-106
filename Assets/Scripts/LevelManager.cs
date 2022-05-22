using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public void LoadGame()
   {
       SceneManager.LoadScene("Level_01");
   }
   public void LoadMainMenu()
   {
       SceneManager.LoadScene("MainMenu");
   }

   public void LoadGameOver()
   {
       SceneManager.LoadScene("GameOver");
   }

   public void QuitGame(){
       Debug.Log("Qutting game...");
       Application.Quit();
   }
}
