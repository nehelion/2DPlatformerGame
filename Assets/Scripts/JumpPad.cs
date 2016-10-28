using UnityEngine;
using System.Collections;

public class JumpPad : JumpAnim {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            hitJ = true;
        }
    }
}
