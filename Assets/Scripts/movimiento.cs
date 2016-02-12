using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	public float movementSpeed;

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * Time.deltaTime*movementSpeed);
	}
}
