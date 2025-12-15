using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
  public float speed ;
  public float RotSpeed;
  public bool gameOver = false;
  public GameObject gameOverObj;
  public GameObject explosion;
    
    void Start() {
        gameOver = false;
        if(gameOverObj != null) {
            gameOverObj.SetActive(false);
        }
    }
    
    // Update is called once per frame
    void Update() {
        if(gameOver == true){
            gameObject.GetComponent<SpriteRenderer>().enabled=false;
            gameOverObj.SetActive(true);
            return;
        }
        
        transform.Translate(Vector3.up * speed * Time.deltaTime );
        if(Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Rotate(new Vector3(0,0,-1) * RotSpeed * Time.deltaTime); 
        }
        if(Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Rotate(new Vector3(0,0,1) * RotSpeed * Time.deltaTime); 
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("enemy"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameOver=true;
 
        }
    }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
