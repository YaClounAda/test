using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private float Timer;
    [SerializeField] private float TimesToPrint = 10f;
    private float TimesPrinted = 0f;

    void Update()
    {
        if (TimesPrinted < TimesToPrint)
            Timer += Time.deltaTime;

        if (Timer >= 1)
        {
            print("Hello, world!");
            Timer = 0;
            TimesPrinted++;
        }
    }
}
