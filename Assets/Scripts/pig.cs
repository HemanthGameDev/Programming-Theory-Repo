using UnityEngine;

public  class pig : Animal
{
    Rigidbody body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
        AnimalName = "Piggy";
        AnimalColor = Color.white;
    }

    protected override void Jump()
    {
        body.AddForce(new Vector3(0f,1f,0f) * 5f,ForceMode.Impulse);
    }
   
}
