using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageProcessing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/**
	Scrub funtion to scrub the white backgroud from the captured image.
	**/
	void Scrub() {
		//create array and get the pixels
		Color[] pix = getPixels();
		int n = 0;
		//iterate over the array
		while (n < pix.length)
		{
			int y = 0;
			//grayscale formula
			y = (pix[n].r * 0.21) + (pix[n].g * 0.72) + (pix[n].b * 0.07);
			//check if pixel is white
			if (y < 128)
			{
				//set white values to clear
				pix[n] = Color.clear;
			}
			//if not white change to black
			else {
				pix[n] = new Color.black;			
			}
			//add to n to move to next pixel
			n++; 
		}
	}
}
