using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape // INHERITANCE
{
    private void Start()
    {
        Points = 0;
        shapeName = "Circle";
    }
    public override void DisplayText() // POLYMORPHISM
    {
        Debug.Log("From Circle.cs");
        base.DisplayText();
    }

}
