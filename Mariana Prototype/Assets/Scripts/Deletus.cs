using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletus : MonoBehaviour
{
    public GameObject objectToSpawn1;
    public GameObject objectToSpawn2;
    public GameObject objectToSpawn3;
    public GameObject objectToSpawn4;
    public GameObject cube;
    public GameObject sphere;
    public GameObject cube2;
    public GameObject sphere2;

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Cube"))
        {
            // When "Cube" is clicked, toggle the visibility of objects as described.
            cube.SetActive(false);
            sphere.SetActive(false);
            sphere2.SetActive(true);
            objectToSpawn1.SetActive(true);
        }
        if (gameObject.CompareTag("Sphere2"))
        {
            sphere2.SetActive(false);
            objectToSpawn1.SetActive(false);
            objectToSpawn2.SetActive(true);
            cube.SetActive(false);
        }
        if (gameObject.CompareTag("Sphere"))
        {
            // When "Cube" is clicked, toggle the visibility of objects as described.
            cube.SetActive(false);
            sphere.SetActive(false);
            cube2.SetActive(true);
            objectToSpawn3.SetActive(true);
        }
        if (gameObject.CompareTag("Cube2"))
        {
            sphere2.SetActive(false);
            objectToSpawn3.SetActive(false);
            objectToSpawn4.SetActive(true);
            sphere.SetActive(false);
        }
    }
}
