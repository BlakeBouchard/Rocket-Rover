using UnityEngine;
using System.Collections;

public class PurpleAlien : Alien {

    public float timeUntilShoot = 1.0f;
    public float timeBetweenBullets = 0.1f;
    public int numBullets = 7;
    public float bulletSpeed = 10.0f;
    public float minBulletAngle = 0.0f;
    public float maxBulletAngle = 180.0f;

    public Transform bulletPrefab;
    
    void Start()
    {
        Jump();
        StartCoroutine("ShootBullets");
    }

    IEnumerator ShootBullets()
    {
        yield return new WaitForSeconds(timeUntilShoot);
        AudioSource[] audioSources = GetComponents<AudioSource>();
        audioSources[1].Play();
        for (float i = 1.0f; i <= numBullets && isActive; i += 1.0f)
        {
            Transform bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as Transform;
            bullet.name = bulletPrefab.name;
            float bulletAngle = (minBulletAngle + ((maxBulletAngle - minBulletAngle) * (i / numBullets)));
            Debug.Log("Bullet " + i + " angle:" + bulletAngle);
            bulletAngle *= Mathf.Deg2Rad;
            bullet.rigidbody2D.velocity = new Vector2(Mathf.Cos(bulletAngle) * bulletSpeed, Mathf.Sin(bulletAngle) * bulletSpeed);
            yield return new WaitForSeconds(timeBetweenBullets);
        }
    }

}
