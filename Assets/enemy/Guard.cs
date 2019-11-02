using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Guard : MonoBehaviour
{
    public float speed;
    public Transform[] movespots;
    private int i;
    public float startwaittime;
    private float waittime;
    private Vector3 localScale;
    private Transform target;
    public Joystick joystick;
    public GameObject tar;
    public static bool noticed = false;


    public int FacingRight;
    public int flag;

    // Start is called before the first frame update
    void Start()
    {
        waittime = startwaittime;
        i = 0;
        flag =0;
        localScale = transform.localScale;
        Physics2D.queriesStartInColliders = false;
        target = tar.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.right * q, distance);

        if ((((target.position.x <= transform.position.x) && (FacingRight == -1)) || ((target.position.x >= transform.position.x) && (FacingRight == 1))) && (Mathf.Abs(target.position.y - transform.position.y) <= 100) && tar.active)
        {

            //Debug.DrawLine(transform.position, hitinfo.point, Color.red);

            noticed = true;
            Debug.Log(noticed);
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), speed * 3 * Time.deltaTime);

        }


        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * 3 * Time.deltaTime);

        else
        {
            //Debug.DrawLine(transform.position, transform.position + transform.right * q * distance, Color.green);
          
         
            transform.position = Vector2.MoveTowards(transform.position, movespots[i].position, speed * Time.deltaTime);
          
            if (Vector2.Distance(transform.position, movespots[i].position) < 0.2f)
            {
                if (waittime <= 0)
                {
                    if (i == 0) i = 1;
                    else i = 0;
                    noticed = false;
                    Debug.Log(noticed);
                    FacingRight *= -1;
                    waittime = startwaittime;
                    localScale.x *= -1;
                    transform.localScale = localScale;
                }

                else waittime -= Time.deltaTime;


            }
        }

    }
}
