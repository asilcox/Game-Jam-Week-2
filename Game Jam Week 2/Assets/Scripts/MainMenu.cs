using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        OptionsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenOptionsMenu()
    {
        if (OptionsMenu != null)
        {
            bool isActive = OptionsMenu.activeSelf;

            OptionsMenu.SetActive(!isActive);
        }
    }
    
    public void MM()
    {
        SceneManager.LoadScene("MainMenu");
    }


   public void PlayGame()
    {
       SceneManager.LoadScene("Main");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
