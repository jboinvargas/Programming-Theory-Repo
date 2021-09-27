using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveDirection : MonoBehaviour
{  
    // ENCAPSULATION
    public float speed { get; protected set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    protected abstract void Move();
}
