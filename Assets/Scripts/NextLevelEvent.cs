using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelEvent : MonoBehaviour {
    
    public string sceneName;
    public bool collided;

    void Update()
    {
        if (collided)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "MainCharacter")
        {
            collided = true;
        }
    }
}
