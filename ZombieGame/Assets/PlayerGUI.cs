using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGUI : MonoBehaviour
{

    public Texture2D crossHair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        float xMin = (Screen.width / 2) - (crossHair.width / 2);
        float yMin = (Screen.height / 2) - (crossHair.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crossHair.width, crossHair.height), crossHair);
    }
}
