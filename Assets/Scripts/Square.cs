using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape // INHERITANCE
{
    private void Start()
    {
        Points = 4;
        shapeName = "Square";
    }
    public override void DisplayText() // POLYMORPHISM
    {
        Debug.Log("From Square.cs");
        base.DisplayText();
    }

}
