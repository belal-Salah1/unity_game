using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
  public float speed ;
  public float RotSpeed;
    // Update is called once per frame
    void Update()
    {
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
}
