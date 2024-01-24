using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public Collider coll;
    private  int points;
    public virtual int Points // ENCAPSULATION
    {
        get {return points; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set negative amount of points!");
                points = 0;
            }
            else
            {
                points = value;
            }
        }
    }

    public virtual string shapeName { get; set; }
    private void Start()
    {
        coll = GetComponent<Collider>();
        Physics.queriesHitTriggers = true;
        coll.isTrigger = true;
    }
    private void OnMouseDown()
    {
        DisplayText();
    }
    
    public virtual void DisplayText() // ABSTRACTION
    {
        
        Debug.Log(shapeName + $" with {points} points");
    }
}
