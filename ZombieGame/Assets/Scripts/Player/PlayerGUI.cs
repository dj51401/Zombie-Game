using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PlayerGUI : MonoBehaviour
{
    public float health = 100;
    public Text healthText;

    public Texture2D crossHair;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemies")
        {
            health -= 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
    }

    private void OnGUI()
    {
        float xMin = (Screen.width / 2) - (crossHair.width / 2);
        float yMin = (Screen.height / 2) - (crossHair.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crossHair.width, crossHair.height), crossHair);
        
    }
}
