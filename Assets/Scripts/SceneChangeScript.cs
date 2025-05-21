using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeScript : MonoBehaviour
{
   
    public void ToLevelOneScene()
    {
        SceneManager.LoadScene("CityScene", LoadSceneMode.Single);
    }

    public void ToLevelTwoScene()
    {
        SceneManager.LoadScene("SecondCityScene", LoadSceneMode.Single);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
