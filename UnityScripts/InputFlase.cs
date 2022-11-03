using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFlase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    public void Input(int s)
    {
        bool y=false;
        if (s == 0)
        {
            y = false;
        }
        else if (s == 1)
        {
            y=true;
        }
        WebGLInput.captureAllKeyboardInput = y;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
