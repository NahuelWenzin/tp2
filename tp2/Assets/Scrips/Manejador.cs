using UnityEngine;
using System.Collections;

public class Manejador : MonoBehaviour
{
    Animator Animations;
    // Use this for initialization
    void Start ()
    {
        Animations = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Animations.SetInteger("Estado", 1);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Animations.SetInteger("Estado", 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Animations.SetInteger("Estado", 2);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Animations.SetInteger("Estado", 0);

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Animations.SetInteger("Estado", 3);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Animations.SetInteger("Estado", 0);

        }

    }
}
