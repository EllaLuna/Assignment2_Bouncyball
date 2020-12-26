using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    private int bricksCount = 21;
    // Start is called before the first frame update
    void Start()
    {
       // bricksCount = GameObject.FindGameObjectsWithTag("Bricks").Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(bricksCount == 0)
        {
            Screens.victory = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bricksCount--;
        Destroy(gameObject);
    }
}
