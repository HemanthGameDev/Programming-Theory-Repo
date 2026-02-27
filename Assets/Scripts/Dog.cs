using UnityEngine;

public  class Dog : Animal
{
    Transform tr;
    private float jumpForce = 2f;
    private void Start()
    {
        tr = transform;
        AnimalName = "Dogesh";
        AnimalColor = Color.white;
    }

    protected override void Jump( )
    {
        tr.Translate(Vector3.up * jumpForce);
    }
}
