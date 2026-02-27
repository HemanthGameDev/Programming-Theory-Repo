using UnityEngine;

public class Cubex : Shape
{
    private void Start()
    {
        ShapeName = "My Cube";
        ShapeColor = Color.green;
    }
    protected override void DisplayText()
    {
       Debug.Log($"Cube Name: {ShapeName}, Cube Color: {ShapeColor}");
    }
    
}
