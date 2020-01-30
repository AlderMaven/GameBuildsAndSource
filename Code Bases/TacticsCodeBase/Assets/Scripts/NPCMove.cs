using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NPCMove : TacticsMove
{

    Animator animator;
    GameObject target;
    public List<GameObject> targets = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Init();
        animator = GetComponent<Animator>();
    }

    void OnEnable()
    {
        Init();
        //creates array of all player objects
        GameObject[] targetsArray = GameObject.FindGameObjectsWithTag("Player");
        targets = targetsArray.ToList();


        while (targets.Count > 0)
        {
            FindNextNearestTarget();
            if (target != null)
            {
                CalculatePath();
            }
        }
        if(actualTargetTile != null)
        {
            FindSelectableTiles();
            actualTargetTile.target = true;
        }
        else
        {
            GetComponent<NPCMove>().enabled = false;
            GetComponent<Strike>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (!moving)
        {

            
        }
        else
        {
            animator.SetInteger("Moving", 1);
            Move();
        }
    }

    void CalculatePath()
    {
        Tile targetTile = GetTargetTile(target);
        FindPath(targetTile);
    }

    void FindNextNearestTarget()
    {
        
            GameObject nearest = null;
            float distance = Mathf.Infinity;

            foreach (GameObject obj in targets)
            {
                float d = Vector3.Distance(transform.position, obj.transform.position);

                if (d < distance)
                {
                    distance = d;
                    nearest = obj;
                }
            }

            target = nearest;
        targets.Remove(target);
    }
}
