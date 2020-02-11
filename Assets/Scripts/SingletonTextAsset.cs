using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTextAsset : Singleton
{
    private TextAsset textAzzet { get { return Instance.textAsset; } set { Instance.textAsset = value; } }

    public Singleton GetSingleton() { return Instance; }

    private SingletonTextAsset()
    {
        //GetSingleton();
    }
    // Start is called before the first frame update
    void Start()
    {
        LoadThing();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadThing()
    {
        TextAsset textFile = Resources.Load<TextAsset>("FileToReadResources");
        textAzzet = textFile;
        if (textAzzet != null)
        {
            Debug.Log("Success reading from Resources");
            Debug.Log(textAzzet.text);
        }
    }
}
