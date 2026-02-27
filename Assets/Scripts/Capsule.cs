using UnityEngine;

public class Capsule : Shape
{
    private void Start()
    {
       ShapeName = "My Capsule";
       ShapeColor = Color.red;
    }
    protected override void DisplayText()
    {
         Debug.Log($"Capsule Name: {ShapeName.ToUpper()}, Capsule Color: {ShapeColor.g}");
    }
   
}
