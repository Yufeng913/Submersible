using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    public static int ScreenWidth = Screen.width;
    public static int ScreenHeight = Screen.height;
    
    private void Start()
    {
        // 2560 1920 1280 640 (- 640)
        // 1440 1080 720 360 (- 360)

        if (ScreenWidth == Screen.width || ScreenHeight == Screen.height)
        {
            ScreenHeight = Screen.width - (640 * 2);
            ScreenWidth = Screen.height - (360 * 2);
            Screen.SetResolution(ScreenWidth, ScreenHeight, true);
        }
        //Screen.SetResolution(1080, 1920, true);
    }

}
