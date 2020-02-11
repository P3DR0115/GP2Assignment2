using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SingletonSystem : Singleton
{
    private static string path;
    private string[] contentt { get { return Instance.content; } set { content = value; } }

    private SingletonSystem()
    {
        //GetSingleton();
        path = AppDomain.CurrentDomain.DynamicDirectory + "SingletonFileToRead.txt";
    }

    public Singleton GetSingleton() { return Instance; }

    // Start is called before the first frame update
    void Start()
    {
        LoadFiles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadFiles()
    {
        try
        {
            contentt = System.IO.File.ReadAllLines(path);

            Debug.Log("Success Reading System");
        }
        catch (Exception e)
        {
            //return new string[1];
        }
    }
}
