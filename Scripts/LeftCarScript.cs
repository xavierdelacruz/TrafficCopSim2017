﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCarScript : MonoBehaviour
{
    public int movementSpeed;
    public float rotatespeed = 1.0f;
    public enum startingPoint { Left, Right, Up, Down };
    public string[] directionMovement = { "Left", "Right", "Straight" };
    public string movement;
    public bool collidable = false;
    public bool straight = false;
    public bool right = false;
    public bool left = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        movementSpeed = 0;
        collidable = true;
    }

    // Use this for initialization
    void Start()
    {
        System.Random random = new System.Random();
        this.movement = directionMovement[random.Next(directionMovement.Length)];
	        movementSpeed = 2;
	    }

	    // Update is called once per frame
    void Update()
    {
    	if (collidable) {
			if (this.movement == "Left" && left) {
				movementSpeed = 3;
           		 transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
           		 transform.Rotate(0, 0, 0.5f);
        		}
    		else if (this.movement == "Right" && right) {
				movementSpeed = 3;
	           	 transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
           		 transform.Rotate(0, 0, -0.5f);
     			   }
    	    else if (this.movement ==  "Straight" && straight){
				movementSpeed = 3;
            	transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
       				}
    		}
    	else {
			transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
    	}
	   

		
	        //use one spawner, make 4 cars spawn from their locations
	        //rotate based on direction

        //transform.position += transform.right * Time.deltaTime * movementSpeed;
    } 

    void RightDown() {
		right = true;
    }

	void RightUp() {
		left = true;
    }

	void Right() {
		straight = true; 
    }
}