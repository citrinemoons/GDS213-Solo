using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject backgroundMusic;
    public AudioSource Death; 
  
    private void Awake()
    {
        DontDestroyOnLoad(backgroundMusic); 
    }
  

    
    void Update()
    {
        
    }

}
