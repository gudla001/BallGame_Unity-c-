using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class selfMove : MonoBehaviour{

	public static int movespeed = 15;
 public Vector3 userDirection = Vector3.right;

     

 public void Update()
 {
     transform.Translate(userDirection * movespeed * Time.deltaTime); 
 }
}