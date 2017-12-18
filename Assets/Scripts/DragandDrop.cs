﻿using UnityEngine;
using UnityEngine.EventSystems;

public class DragandDrop: MonoBehaviour
{
	bool beingDragged;

	// Update is called once per frame
	void Update ()
	{

		Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		bool overSprite = GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);
		beingDragged = beingDragged && Input.GetButton("Fire1");
		if (overSprite)
		{
			//If we've pressed down on the mouse (or touched on the iphone)
			if (Input.GetButton("Fire1"))
			{
				beingDragged = true;
			}
		}
		if (beingDragged) {
			//Set the position to the mouse position
			transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
				Camera.main.ScreenToWorldPoint(Input.mousePosition).y,
				0.0f);
		}
	}

}