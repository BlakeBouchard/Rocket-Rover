using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    public float explodeTick = 0.01f;
    public float explodeExpand = 0.5f;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine("ExpandExplosion");
	}

    IEnumerator ExpandExplosion()
    {
        for (int i = 1; i < 10; i++) {
            transform.localScale = new Vector3(transform.localScale.x + explodeExpand, transform.localScale.y + explodeExpand, 0);
            yield return new WaitForSeconds(explodeTick);
        }
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
