using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressButtonDetection : MonoBehaviour
{
    public UnityEvent whenKeyIsPressed;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown) {
            whenKeyIsPressed?.Invoke();
        }
    }
}
