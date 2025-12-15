using UnityEngine;
using UnityEngine.InputSystem;

public class bulletShooter : MonoBehaviour
{
    public GameObject bulletObj;
    public Transform shootingPoint;
    public float timer;
    public float resetTimer;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed && timer <= 0)
        {
            Instantiate(bulletObj, shootingPoint.position, transform.rotation);
            timer = resetTimer;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
