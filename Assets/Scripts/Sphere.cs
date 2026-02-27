using UnityEngine;

public class Sphere : Shape
{
        private void Start()
        {
            ShapeName = "My Sphere";
            ShapeColor = Color.blue;
    }
    protected override void DisplayText()
    {
         Debug.Log($"Sphere Name: {ShapeName}, Sphere Color: {ShapeColor}, is Round");
    }

    
}
