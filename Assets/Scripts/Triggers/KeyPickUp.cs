using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{

    public DoorCellOpen door;
    public float distance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject key;


    // Update is called once per frame
    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    private void OnMouseOver()
	{
		if(distance <= 2f)
		{
            actionDisplay.SetActive(true);
            actionText.SetActive(true);

		}

        if (distance > 2f)
        {
            actionDisplay.SetActive(false);
            actionText.SetActive(false);

        }

        if (Input.GetButtonDown("Action"))
		{

            if(distance <= 2f)
			{
                this.GetComponent<BoxCollider>().enabled = false;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                door.hasKey = true;
            }
            
		}
         
	}

	private void OnMouseExit()
	{
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}