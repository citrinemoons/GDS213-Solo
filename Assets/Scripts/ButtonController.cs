using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject checklist;
    [SerializeField] private GameObject buttons;
    [SerializeField] private GameObject checklistButton;
    [SerializeField] private GameObject finishedButton;
    [SerializeField] private GameObject finishedMenu;
    [SerializeField] private GameObject cat;
    [SerializeField] private GameObject cleaningKit;
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
        if(checklist.activeInHierarchy == true)
        {
            checklist.SetActive(false);
        }
        else
        {
            checklist.SetActive(true);
        }
    }


    public void Finished()
    {
        finishedMenu.SetActive(true);
        buttons.SetActive(false);
        checklistButton.SetActive(false);
        finishedButton.SetActive(false);
        cat.SetActive(false);
        cleaningKit.SetActive(false);
        
        
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

