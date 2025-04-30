using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    // Declare and initialize a List of strings
    private List<string> fruits = new List<string>();

    void Start()
    {
        // Add items to the list
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");

        // Print out the contents of the list
        foreach (string fruit in fruits)
        {
            Debug.Log(fruit);
        }
    }
}
