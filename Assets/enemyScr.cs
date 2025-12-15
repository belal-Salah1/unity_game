using UnityEngine;

public class enemyScr : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private playerMovement playerScr;
    public GameObject explosion;

    private void Start()
    {
       target = GameObject.FindGameObjectWithTag("Player");
       playerScr = target.GetComponent<playerMovement>();
    }
    // Update is called once per frame
    void Update()
    {
       
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("bullet"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
