﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour {

    public GameObject bulletScore;
    public int score;

    // Use this for initialization
    void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
<<<<<<< HEAD
       /* if (collision.bulletScore.tag == "Enemy")
        {
            score = score  + 5;
            Debug.Log(score.ToString());
        }*/
=======
        //if (collision.bulletScore.tag == "Enemy")
        //{
        //    score = score  + 5;
        //    Debug.Log(score.ToString());
        //}
>>>>>>> 5c7140ac861f3d8899c9e1935ec8809c304402f5

     }
}
