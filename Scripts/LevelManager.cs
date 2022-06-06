using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
  public void LoadGame()
   {
       SceneManager.LoadScene("1");
   }
   public void LoadOptions(){
       SceneManager.LoadScene("01 OptionsScene");
   }
   public void LoadMainMenu()
   {
       SceneManager.LoadScene("0");
   }
   public void LoadGameOver()
   {
       SceneManager.LoadScene("4");
   }

   public void QuitGame(){
       Debug.Log("Qutting game...");
       Application.Quit();
   }
  
}
