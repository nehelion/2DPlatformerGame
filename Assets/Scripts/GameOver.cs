using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject menu;
    public string sceneName;
    public bool collided;

    void Update()
    {
        if (collided && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "MainCharacter")
        {
            Instantiate(menu, Vector3.zero , Quaternion.identity);
            collided = true;
        }
    }
}
