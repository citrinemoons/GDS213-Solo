using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{

    public GameObject bubbles;
    public GameObject water;
    public GameObject dryer;
    public GameObject finishButton; 

    //Bools for locking the finished button 
    [SerializeField] private bool isBubbles;
    [SerializeField] private bool isWater;
    [SerializeField] private bool isDryer;

    //player can access the button now 
    [SerializeField] private bool canFinish; 
    [SerializeField] private bool isFinish;

    void Start()
    {
        isBubbles = false;
        isWater = false;
        isDryer= false;
        canFinish = false;
        isFinish = false;
    }


    void Update()
    {
        if (isBubbles == true && isWater == true && isDryer == true && !canFinish)
        {
            canFinish = true;
            Finished();
        }
        

    }


    public void BubbleBath()
    {
        isBubbles = true;
        //bubble time
        bubbles.SetActive(true);
      

        //incase people press all the buttons at once 
        water.SetActive(false);
        dryer.SetActive(false);
    }


    public void HoseDown()
    {
        //wash the cat 
        water.SetActive(true);
        isWater = true;


        //incase people press all the buttons at once 
        dryer.SetActive(false);
        bubbles.SetActive(false);

    }


    public void DryOff()
    {
        //dry the cat
        dryer.SetActive(true);
        isDryer = true; 


        //incase people press all the buttons at once 
        water.SetActive(false);
        bubbles.SetActive(false);
    }


    public void Finished()
    {
        if (!isFinish) 
        {
            finishButton.SetActive(true);
            isFinish = true;
            Debug.Log("plz fuckin do the thing?");
        }
     
    }


}
