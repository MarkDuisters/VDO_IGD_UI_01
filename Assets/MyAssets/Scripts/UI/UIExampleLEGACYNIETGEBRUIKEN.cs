using UnityEngine;


public class UIExampleLEGACYNIETGEBRUIKEN : MonoBehaviour
{


    // Update is called once per frame
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, Screen.height / 2, Screen.width, 50), "Button"))
        {
            Debug.Log("Button Clicked");
        }
    }
}
