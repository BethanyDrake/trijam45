using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetController : MonoBehaviour
{

    private AudioSource source;
    public AudioClip[] sounds;

    private bool alive;
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

     void Awake () {

        source = GetComponent<AudioSource>();
    }


    void OnCollisionEnter (Collision coll)
    {
        Debug.Log(coll.gameObject.tag);
        if (coll.gameObject.tag == "projectile" && alive) {
            alive = false;
             AudioClip sound = sounds[Random.Range(0,sounds.Length)];
             source.PlayOneShot(sound);

        }


    }
}
