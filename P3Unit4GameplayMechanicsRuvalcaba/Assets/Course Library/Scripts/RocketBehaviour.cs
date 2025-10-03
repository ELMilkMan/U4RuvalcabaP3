using UnityEngine;

public class RocketBehaviour : MonoBehaviour
{
    private Transform target;
    private float speed = 15.0f;
    private bool homing;

    private float rocketStrength = 15.0f;
    private float aliveTimer = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        if(homing && target != null)
        {
            Vector3 movedirection = (target.transform.position - transform.position).normalized;
            transform.position += movedirection * speed * Time.deltaTime;
            transform.position += movedirection * speed * Time.deltaTime;
            transform.LookAt(target);
        }
    }

    public void Fire(Transform newtarget)
    {
        target = homingTarget;
        homing = true;
        Destroy(gameObject, aliveTimer);
    }
}
