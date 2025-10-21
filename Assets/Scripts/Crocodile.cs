using UnityEngine;

public class Crocodile : Enemy
{
    [SerializeField] float atkRange;
    public Player player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(50);
        DamageHit = 30;
        //set atk range and target
        atkRange = 6.0f;
        player = GameObject.FindFirstObjectByType<Player>();
    }

    private void FixedUpdate()
    {
        Behavior();
    }


    public override void Behavior()
    {
        //find distance between Croccodile and Player
        Vector2 distance = transform.position - player.transform.position;
        if (distance.magnitude <= atkRange)
        {
            Debug.Log($"{player.name} is in the {this.name}'s atk range!");
            Shoot();
        }
    }

    public void Shoot()
    {
        Debug.Log($"{this.name} shoots rock to the {player.name}!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
