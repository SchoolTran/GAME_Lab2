using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;
    public GameObject Egg;
    private int score = 0;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("platform"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this);
        }
        if (col.gameObject.name.Equals("Egg"))
        {
            Instantiate (EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this);
        }
        if (col.gameObject.name.Equals("Farmer"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this);
        }

        if (col.gameObject.name.Equals("Box"))
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(gameObject, 0.1f);
            Destroy(this);
        }
    }
}
