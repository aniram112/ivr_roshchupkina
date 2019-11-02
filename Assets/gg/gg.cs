using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gg : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float dirX;
    private float moveSpeed;
    private bool facingRight = true;
    private Vector3 localScale;
    public Joystick joystick;
    public static bool able_to_hide = false;
    private bool ntcd;
    private bool busted;
    public AchievementDatabase database;
    public Trophies locked;
    public AchievementNotificationController achievementNotificationController;
    //public GameObject one;

    public Death ded;


    // Use this for initialization
    private void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed = 300f;
    }

    // Update is called once per frame
    private void Update()
    {
        ntcd = Guard.noticed;
        dirX = joystick.Horizontal * moveSpeed;
        

        if (Mathf.Abs(dirX) > 0 && rb.velocity.y == 0)
            anim.SetBool("isRunning", true);
        else
            anim.SetBool("isRunning", false);

        if (QTE.failed){
            moveSpeed = 300f;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }
    private void LateUpdate()
    {
        if (dirX > 0)
            facingRight = true;

        else if (dirX < 0)
            facingRight = false;

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;

        transform.localScale = localScale;


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spot") && ntcd== false)
        {
            able_to_hide = true;
        }
        else able_to_hide = false;

        if (other.CompareTag("Guard")){
            StartCoroutine(myCor());
        }
        if (other.name == "QTEStart" && !QTE.done)
        {
            moveSpeed = 0f;
           //one.SetActive(true);

        }
        if (other.name == "QTEFinish")
        {
            moveSpeed = 300f;
        }


    }
    IEnumerator myCor()
    {
        if (locked.GetLock(4) == 0)
        {
            achievementNotificationController.ShowNotification(database.achievements[4]);
            locked.Unlock(4);
            moveSpeed = 0f;
            yield return new WaitForSeconds(3);

        }
        ded.Dead();

    }



}
