using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
public static Locator Instance { get; private set; }
public W4Pigeon pigeon {get; private set;}
private void Awake() 
{
    if (Instance != null && Instance != this) 
    {
        Destroy(this);
        return;
    }
    Instance = this;
    GameObject thePigeon = GameObject.FindWithTag("Player");
    pigeon = thePigeon.GetComponent<W4Pigeon>();
}

}
