using UnityEngine;

public abstract class Shape : MonoBehaviour
{
     private string shapeName;
     public string ShapeName
    {
        get { return shapeName; }
       protected set{ shapeName = value; }
    }

     private Color shapeColor;
    public Color ShapeColor
    {
        get { return shapeColor; }
        protected set { shapeColor = value; }
    }

    protected abstract void DisplayText();
   

    public void HandleClick()
    {
                DisplayText();
    }
    public void OnMouseDown()
    {
        HandleClick();
    }


}