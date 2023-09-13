using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletus : MonoBehaviour
{
    [SerializeField]
    private GameObject object1;
    [SerializeField]
    private GameObject object2;
    
    private void OnMouseDown()
    {
        // Destroy the block when it is clicked
        Destroy(gameObject);
        if (object2 == null)
        {
            object1.SetActive(true);
        }
    }
}
