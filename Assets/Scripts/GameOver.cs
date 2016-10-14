using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{
    public GameObject menu;
    private bool isShowing = false;

    void Update()
    {
        menu.SetActive(isShowing);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "MainCharacter")
        {
            isShowing = !isShowing;
        }
    }
}
