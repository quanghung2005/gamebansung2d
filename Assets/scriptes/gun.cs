using Microsoft.Win32.SafeHandles;
using UnityEngine;

public class gun : MonoBehaviour
{
    private float rotationoffset = 180f;
    [SerializeField] private Transform firepsos;
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private float shotdelay = 0.15f;
    private float nextshot;
    [SerializeField] private int maxammo = 24;
    [SerializeField]private int currentammo;
    void Start()
    {
        currentammo = maxammo;
    }


    void Update()
    {
        rotategun();
        shoot();
        reload();
    }
    void rotategun()
    {   
        if(Input.mousePosition.x<0|| Input.mousePosition.x>Screen.width|| Input.mousePosition.y<0|| Input.mousePosition.y > Screen.width)
        {
            return;
        }
        Vector3 displacement = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + rotationoffset));
        if (angle<-90||angle>90)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1,-1, 1);
        }  
    }
    void shoot()
    {
        if (Input.GetMouseButtonDown(0) && currentammo > 0 && Time.time > nextshot)
        {
            nextshot = Time.time + shotdelay;
            Instantiate(bulletprefab, firepsos.position, firepsos.rotation);
            currentammo--;
        }
    }
    void reload()
    {
        if (Input.GetKeyDown(KeyCode.R) && currentammo < maxammo)
        {
            currentammo = maxammo;
           
        }
    }

}