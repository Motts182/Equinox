using UnityEngine;
using System.Collections;

public class AttakTrigger : MonoBehaviour {

    public int dmg = 20;

    void OnTriggerEnter2D(Collider2D other) {
        print("ENter Trigger Atk");
        if (other.CompareTag("Enemy")) {
            print("ENter Enemy");
            other.GetComponentInParent<TurretIA>().Demage(dmg);
        }
    }
}
