using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI tmpText;
    void Start()
    {
        float time = PlayerPrefs.GetFloat("timer", 0f);
        tmpText.text = "Time: \n" + time.ToString("N2"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
