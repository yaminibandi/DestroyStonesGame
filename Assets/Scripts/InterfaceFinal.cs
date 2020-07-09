﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class InterfaceFinal : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text="Number of Stones: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text="Destrooyed: "+ GameManager.currentDestroyedStones;
        
    }
    public void Click(){
        SceneManager.LoadScene("Awake");
    }
}
