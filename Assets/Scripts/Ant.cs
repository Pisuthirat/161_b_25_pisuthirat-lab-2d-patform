using UnityEngine;

public class Ant : Enemy
{

    [SerializeField] Vector2 velocity;
    public Transform[] MovePoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(20);

        DamageHit = 20;

        velocity = new Vector2(-1.0f, 0.0f);
    }

    public override void Behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        Behavior();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
