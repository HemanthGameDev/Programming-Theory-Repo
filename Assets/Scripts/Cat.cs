using UnityEngine;

public class Cat : Animal
{
    Transform tr;
    private float jumpForce = 3f;
    private MeshRenderer color;
    private void Start()
    {
        color = GetComponent<MeshRenderer>();
        tr = transform;
        AnimalName = "Catzy";
        AnimalColor = Color.black;
    }

    protected override void Jump()
    {
        Color newColor = new Color(Random.Range(0, 1), Random.Range(0, 1),Random.Range(0,1));
        tr.Translate(Vector3.up * jumpForce);
        color.material.color = newColor;
    }
}
