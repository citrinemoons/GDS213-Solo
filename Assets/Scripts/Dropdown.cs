using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Dropdown : MonoBehaviour
{
    public TextMeshProUGUI answer;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    void DropDown(int val)
    {
        if(val == 0)
        {
            answer.text = "Main Coon"; 
        }
    }
}
