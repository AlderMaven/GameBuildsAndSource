using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : TacticsMove
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Init();
        animator = GetComponent<Animator>();
        FindSelectableTiles();
        targetable = false;
    }

    private void OnEnable()
    {
        Init();
        FindSelectableTiles();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(!moving)
        {
            
            CheckMouse();
        }
        else
        {
            animator.SetInteger("Moving", 1);
            Move();
        }
        
    }


    //When the player clicks on a tile, the character moves to that tile
    void CheckMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Tile")
                {
                    Tile t = hit.collider.GetComponent<Tile>();
                    if (t.selectable)
                    {
                        MoveToTile(t);
                    }
                }
            }
        }
    }
}
