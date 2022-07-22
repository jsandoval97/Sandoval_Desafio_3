using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 2f;
    public Vector3 direction = new Vector3(1f,0f,0f);
    public int damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move(){
        transform.position += speed * direction * Time.deltaTime; 
    }
}
