using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
  public void LoadLevel()
    {
        SceneManager.LoadScene("arma5");
    }
   public void ExitGame()
    {
      Application.Quit();
      Debug.Log("Exit");
    }
}
