using UnityEngine;
using System.Collections;

public class GroundedCheck : MonoBehaviour {
    
    private Characte2D _char;

    void Awake(){
        _char = GetComponentInParent<Characte2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
            _char.grounded = true;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
            _char.grounded = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
            _char.grounded = false;
    }


}
