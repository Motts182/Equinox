using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIHealth : MonoBehaviour {

    public Slider hSlider;
    public Characte2D c2D;

	void Update () {
        hSlider.value = c2D.curHealth;
	}
}
