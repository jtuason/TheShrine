using UnityEngine;
using System.Collections;

public class PickupObjects : MonoBehaviour {

    private bool isOverlapping;
    private Collider otherObj;
    private GameObject holdingUI;

	// Use this for initialization
	void Start () {
        holdingUI = gameObject.transform.GetChild(0).GetChild(2).gameObject;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("space"))
        {
            if (isOverlapping)
            {
                Destroy(otherObj.gameObject);
                holdingUI.SetActive(true);
            }
            
        }

	}

    void OnTriggerEnter(Collider other)
    {
        isOverlapping = true;
        otherObj = other;
    }

    void OnTriggerExit(Collider other)
    {
        isOverlapping = false;
    }

}
