using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
public class move : MonoBehaviour
{
    public TMP_Text text;
    bool left;
    bool right;
    bool up;
    bool down;
    float x;
    float y;
    private void Start()
    {
        x=Screen.width/100;
        y=Screen.height/100;
    }
    private void Update()
    {
        if (right && gameObject.transform.position.x < x)
            gameObject.transform.position += Vector3.right * Time.deltaTime;
        if (left&&gameObject.transform.position.x>-x)
            gameObject.transform.position += Vector3.left * Time.deltaTime;
        if (up && gameObject.transform.position.x < y)
            gameObject.transform.position += Vector3.up * Time.deltaTime;
        if (down && gameObject.transform.position.x > -y)
            gameObject.transform.position += Vector3.down * Time.deltaTime;

    }
    public void MoveLeft(string s)
    {
        left = true ? s == "1" : left;
    }
    public void MoveRight(string s)
    {
        right = true ? s == "1" : right;
    }
    public void MoveUp(string s)
    {
        up = true ? s == "1" : up;
    }
    public void MoveDown(string s)
    {
        down = true ? s == "1" : down;
    }
    public void sendText(string s)
    {
        text.text = s;
    }
}
