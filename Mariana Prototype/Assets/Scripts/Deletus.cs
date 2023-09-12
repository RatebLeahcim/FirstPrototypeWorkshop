using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletus : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Destroy the block when it is clicked
        Destroy(gameObject);
    }
}
