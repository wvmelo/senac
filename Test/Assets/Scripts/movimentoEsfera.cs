using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoEsfera : MonoBehaviour {

    // Use this for initialization
    public float speed;
    private Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 moviment = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(moviment * speed);
	}

    void Update() {

    }

}
