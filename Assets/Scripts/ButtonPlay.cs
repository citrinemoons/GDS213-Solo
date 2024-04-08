using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{

    public GameObject bubbles;
    public GameObject water;
    public GameObject dryer; 

    void Start()
    {
        
    }


    void Update()
    {
        
    }


    public void BubbleBath()
    {
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

        //incase people press all the buttons at once 
        dryer.SetActive(false);
        bubbles.SetActive(false);

    }


    public void DryOff()
    {
        //dry the cat
        dryer.SetActive(true);


        //incase people press all the buttons at once 
        water.SetActive(false);
        bubbles.SetActive(false);
    }


}
