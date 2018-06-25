using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPButton : MonoBehaviour {
    [SerializeField]
    bool isNext = true;
    [SerializeField]
    OPManager eventSystem;
    void OnMouseDown()
    {
        if (isNext)
            eventSystem.NextOP();
        else
            eventSystem.PreviousOP();
    }
}
