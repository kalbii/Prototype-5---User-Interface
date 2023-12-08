using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    private Animator SkeletonAnim;

    // Start is called before the first frame update
    void Start()
    {
        SkeletonAnim = GetComponent<Animator>();

        //SkeletonAnim.Play("Skill");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SkeletonDeath()
    {
        SkeletonAnim.SetBool("IsAlive", false);
    }
}
