using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GuardQTE : MonoBehaviour
{
    public float speed;
    public Transform waitspot;
    private int i;
    public float startwaittime;
    private float waittime;
    private Vector3 localScale;
    private Transform target;
    public Joystick joystick;
    public GameObject tar;
    public static bool noticed = false;
    public bool failed;



    public int FacingRight;
    public int flag;

    // Start is called before the first frame update
    void Start()
    {
        waittime = startwaittime;
        i = 0;
        flag = 0;
        localScale = transform.localScale;
        Physics2D.queriesStartInColliders = false;
        target = tar.GetComponent<Transform>();
        failed = false;

    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.right * q, distance);

        if ((((target.position.x <= transform.position.x) && (FacingRight == -1)) || ((target.position.x >= transform.position.x) && (FacingRight == 1))) && (Mathf.Abs(target.position.y - transform.position.y) <= 100) && tar.active)
        {

            //Debug.DrawLine(transform.position, hitinfo.point, Color.red);

            noticed = true;
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), speed * 3 * Time.deltaTime);

        }


        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * 3 * Time.deltaTime);

        else
        {
            //Debug.DrawLine(transform.position, transform.position + transform.right * q * distance, Color.green);

            if (transform.position != waitspot.position)
            {   if (FacingRight == -1)
                {
                    FacingRight = 1;
                    localScale.x *= -1;
                    transform.localScale = localScale;
                }
                transform.position = Vector2.MoveTowards(transform.position, waitspot.position, speed * Time.deltaTime);
            }

            if (QTE.failed && !failed)
            {
                    //Debug.Log(QTE.failed);
                    noticed = true;
                    FacingRight *= -1;
                    localScale.x *= -1;
                    transform.localScale = localScale;
                    failed = true;

            }
        }

    }
}
