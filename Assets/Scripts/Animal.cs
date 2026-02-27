using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string animalName;

    public string AnimalName
    {
        get { return animalName; }
        protected set { animalName = value; }
    }
    private Color animalColor;
    public Color AnimalColor { get; protected set; }

    protected abstract void Jump();

    void Handleclick()
    {
        Jump();
    }
    private void OnMouseDown()
    {
        Handleclick();
    }
}
