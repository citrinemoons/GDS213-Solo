using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{


    void Start()
    {


    }
    

    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene("Intro Scene");
    }

    public void Go()
    {   
        SceneManager.LoadScene("Main Coon");
    }

    public void BackToMain()
    {
        //I feel like this is pretty self explaining, but, this lets players out of options back to the main menu
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        Debug.Log("Bye for now :3");
        Application.Quit();
    }


    public void ChecklistButton()
    {
        gameObject.SetActive(true);
    }

    public void BackToWash()
    {
        gameObject.SetActive(false);
    }


    public void DeathScreen()
    {
        SceneManager.LoadScene("Death"); 
    }


   public void British()
    {
        SceneManager.LoadScene("British Shorthair");
    }


    public void Scottish()
    {
        SceneManager.LoadScene("Scottish Fold");
    }


    public void LetGo()
    {
        SceneManager.LoadScene("Let Go");
    }


    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }



}

