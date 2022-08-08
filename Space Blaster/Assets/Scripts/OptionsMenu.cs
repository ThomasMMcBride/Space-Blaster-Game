using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{

    public Slider slider; 

    public static float musicVolume = 0.70f;

    // updates musicVolume based on slider value
    void Update()
    {
        musicVolume = slider.value;
    }
}
