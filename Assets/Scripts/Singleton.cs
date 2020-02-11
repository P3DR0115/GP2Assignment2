using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    //Private Static instance
    private static Singleton instance;
    public string[] content;
    public TextAsset textAsset;

    //Private Constructor
    protected Singleton() { instance = new Singleton(); }

    //Accessible Public instance
    protected static Singleton Instance
    {
        get
        {
            //Lazy Load
            if (instance == null)
            {
                instance = new Singleton();
                instance.textAsset = new TextAsset();
            }
            return instance;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
