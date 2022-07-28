using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WATCHSELEC : MonoBehaviour
{
    public GameObject WatchM1;
    public GameObject WatchM2;
    public GameObject WatchM3;

    public GameObject WatchWindow1;
    public GameObject WatchWindow2;
    public GameObject WatchWindow3;

    public GameObject CloseButton1;
    public GameObject CloseButton2;
    public GameObject CloseButton3;

    public Animation w1WindowAnim;
    public Animation w2WindowAnim;
    public Animation w3WindowAnim;


    // Start is called before the first frame update
    void Start()
    {
        w1WindowAnim = WatchWindow1.GetComponent<Animation>();
        w2WindowAnim = WatchWindow2.GetComponent<Animation>();
        w3WindowAnim = WatchWindow3.GetComponent<Animation>();

    }

    public void Watch1BC()
    {
        WatchM1.SetActive(true);
        WatchM2.SetActive(false);
        WatchM3.SetActive(false);

        w1WindowAnim["W1ANIM"].speed = 1;
        w1WindowAnim.Play();
    }

    public void Watch2BC()
    {
        WatchM1.SetActive(false);
        WatchM2.SetActive(true);
        WatchM3.SetActive(false);

        w2WindowAnim["W2ANIM"].speed = 1;
        w2WindowAnim.Play();


    }

    public void Watch3BC()
    {
        WatchM1.SetActive(false);
        WatchM2.SetActive(false);
        WatchM3.SetActive(true);

        w3WindowAnim["W3ANIM"].speed = 1;
        w3WindowAnim.Play();
    }

    public void closeButton1()
    {
            w1WindowAnim["W1ANIM"].speed = -1;
            w1WindowAnim["W1ANIM"].time = w1WindowAnim["W1ANIM"].length;
            w1WindowAnim.Play();
     }

    public void closeButton2()
    {
        w2WindowAnim["W2ANIM"].speed = -1;
        w2WindowAnim["W2ANIM"].time = w2WindowAnim["W2ANIM"].length;
        w2WindowAnim.Play();
    }

    public void closeButton3()
    {
        w3WindowAnim["W3ANIM"].speed = -1;
        w3WindowAnim["W3ANIM"].time = w3WindowAnim["W3ANIM"].length;
        w3WindowAnim.Play();
    }

    /*public void closeButtonOnClick()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName = "w1close")
        {
            w1WindowAnim["W1ANIM"].speed = -1;
            w1WindowAnim["W1ANIM"].time = w1WindowAnim["W1ANIM"].length;
            w1WindowAnim.Play();
        }

        else if (buttonName = "w2close")
        {
            w2WindowAnim["W2ANIM"].speed = -1;
            w2WindowAnim["W1ANIM"].time = w2WindowAnim["W2ANIM"].length;
            w2WindowAnim.Play();
        }

        else if (buttonName = "w3close")
        {
            w3WindowAnim["W3ANIM"].speed = -1;
            w3WindowAnim["W3ANIM"].time = w3WindowAnim["W3ANIM"].length;
            w3WindowAnim.Play();
        }*/

    // Update is called once per frame

}
