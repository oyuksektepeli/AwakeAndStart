using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Awake is callded even if component is disabled
    void Awake()
    {
        Debug.Log("Awake called.");
    }

    // Start is called before the first frame update
    // if component enabled
    void Start()
    {
        Debug.Log("Start called.");
    }
}
