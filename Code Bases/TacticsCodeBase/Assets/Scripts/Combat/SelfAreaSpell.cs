using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfAreaSpell : MonoBehaviour
{
    int damage;
    int damageType;
    int accuracy;

    public List<Tile> selectableTiles = new List<Tile>();
    public List<GameObject> targets = new List<GameObject>();
    GameObject[] tiles;
    public Tile currentTile;
    public AudioClip MusicClip;

    public AudioSource MusicSource;

    // Start is called before the first frame update
    void OnEnable ()
    {
        if (GetComponent<CharacterStats>().usingSkill == 1)
        {
            damage = GetComponent<CharacterStats>().skill_1.statModifier["Damage"];
            damageType = GetComponent<CharacterStats>().skill_1.DamageType;
            accuracy = GetComponent<CharacterStats>().skill_1.accuracy;
        }
        else if (GetComponent<CharacterStats>().usingSkill == 2)
        {
            damage = GetComponent<CharacterStats>().skill_2.statModifier["Damage"];
            damageType = GetComponent<CharacterStats>().skill_2.DamageType;
            accuracy = GetComponent<CharacterStats>().skill_2.accuracy;
        }
        else if (GetComponent<CharacterStats>().usingSkill == 3)
        {
            damage = GetComponent<CharacterStats>().skill_3.statModifier["Damage"];
            damageType = GetComponent<CharacterStats>().skill_3.DamageType;
            accuracy = GetComponent<CharacterStats>().skill_3.accuracy;
        }

        tiles = GameObject.FindGameObjectsWithTag("Tile");

        FindTargets();
        DoSpell();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndSpell()
    {
        targets.Clear();
        if (currentTile != null)
        {
            currentTile.current = false;
            currentTile = null;
        }

        foreach (Tile tile in selectableTiles)
        {
            tile.Reset();
        }

        selectableTiles.Clear();

        Animator animator = GetComponent<Animator>();
        animator.SetInteger("Attacking", 0);

        GetComponent<Standby>().enabled = true;
        GetComponent<SelfAreaSpell>().enabled = false;
    }


    public void DoSpell()
    {
        if(damageType == 1)
        {
            Debug.Log("Physical spell");
            foreach(GameObject target in targets)
            {
                if (Random.Range(1, 100) <= accuracy)
                {
                    MusicSource.clip = MusicClip;
                    MusicSource.Play();
                    Debug.Log("Spell Hit");
                    if (target.GetComponent<CharacterStats>().Defense > damage)
                    {

                    }
                    else
                    {
                        if (target.GetComponent<Defend>().enabled)
                        {
                            int originalHealth = target.GetComponent<CharacterStats>().HealthPoints;
                            target.GetComponent<CharacterStats>().HealthPoints = (target.GetComponent<CharacterStats>().HealthPoints + target.GetComponent<CharacterStats>().Defense) - damage;
                            int difference = (originalHealth - target.GetComponent<CharacterStats>().HealthPoints) / 2;
                            target.GetComponent<CharacterStats>().HealthPoints = target.GetComponent<CharacterStats>().HealthPoints + difference;
                        }
                        else
                        {
                            target.GetComponent<CharacterStats>().HealthPoints = (target.GetComponent<CharacterStats>().HealthPoints + target.GetComponent<CharacterStats>().Defense) - damage;
                        }
                    }
                    if (target.GetComponent<CharacterStats>().HealthPoints <= 0)
                    {
                        Kill(target);
                    }
                }
                else
                {
                    Debug.Log("Spell Missed");
                }
            }
        }
        else if(damageType == 2)
        {
            foreach (GameObject target in targets)
            {
                if (Random.Range(1, 100) <= accuracy)
                {
                    Debug.Log("Spell Hit");
                    if (target.GetComponent<CharacterStats>().MagDefense > damage)
                    {

                    }
                    else
                    {
                        if (target.GetComponent<Defend>().enabled)
                        {
                            int originalHealth = target.GetComponent<CharacterStats>().HealthPoints;
                            target.GetComponent<CharacterStats>().HealthPoints = (target.GetComponent<CharacterStats>().HealthPoints + target.GetComponent<CharacterStats>().MagDefense) - damage;
                            int difference = (originalHealth - target.GetComponent<CharacterStats>().HealthPoints) / 2;
                            target.GetComponent<CharacterStats>().HealthPoints = target.GetComponent<CharacterStats>().HealthPoints + difference;
                        }
                        else
                        {
                            target.GetComponent<CharacterStats>().HealthPoints = (target.GetComponent<CharacterStats>().HealthPoints + target.GetComponent<CharacterStats>().MagDefense) - damage;
                        }
                    }
                    if (target.GetComponent<CharacterStats>().HealthPoints <= 0)
                    {
                        Kill(target);
                    }
                }
                else
                {
                    Debug.Log("Spell Missed");
                }
            }
        }

        EndSpell();

    }

    //Kill function for a target
    public void Kill(GameObject target)
    {
        if (target.tag == "NPC")
        {
            //PLACE FOR GIVING EXPERIENCE FOR NPC KILL
            GetComponent<CharacterStats>().Experience = GetComponent<CharacterStats>().Experience + target.GetComponent<CharacterStats>().Experience;
            //check?.LevelUP();
        }
        //target.GetComponent<Dead>().enabled = true; Need to be used in turns.cs to keep track of characters

    }

    public void GetCurrentTile()
    {
        currentTile = GetTargetTile(gameObject);
        currentTile.current = true;
    }

    public Tile GetTargetTile(GameObject target)
    {
        RaycastHit hit;
        Tile tile = null;
        if (Physics.Raycast(target.transform.position, -Vector3.up, out hit, 1))
        {
            tile = hit.collider.GetComponent<Tile>();
        }
        return tile;
    }

    public void ComputeAdjacencyLists(Tile target)
    {
        foreach (GameObject tile in tiles)
        {
            Tile t = tile.GetComponent<Tile>();
            t.FindNeighborsAttack(1, target);
        }
    }

    public void FindTargets()
    {
        //Finds the tiles within range
        FindSelectableTiles();

        //From the tiles within range, adds any characters on those tiles 
        Vector3 halfExtents = new Vector3(0.25f, 1f, 0.25f);
        foreach (Tile tile in selectableTiles)
        {
            RaycastHit hit;

            if (Physics.Raycast(tile.transform.position, Vector3.up, out hit, 1))
            {

                if (hit.collider.GetComponent<CharacterStats>() != null && (hit.collider.GetComponent<CharacterStats>().team != GetComponent<CharacterStats>().team))
                {

                    hit.collider.GetComponent<TacticsMove>().targetable = true;


                    targets.Add(hit.collider.gameObject);
                }


            }
        }

    }


    //Breadth First Search of possible tiles from the current tile within the range
    public void FindSelectableTiles()
    {
        ComputeAdjacencyLists(null);
        GetCurrentTile();

        Queue<Tile> process = new Queue<Tile>();

        process.Enqueue(currentTile);
        currentTile.visited = true;

        while (process.Count > 0)
        {
            Tile t = process.Dequeue();

            if (!t.current)
            {
                selectableTiles.Add(t);
                t.targetable = true;
            }


            if (t.distance < 2)
            {
                foreach (Tile tile in t.adjacencyList)
                {
                    if (!tile.visited)
                    {
                        tile.parent = t;
                        tile.visited = true;
                        tile.distance = 1 + t.distance;
                        process.Enqueue(tile);
                    }
                }
            }
        }
    }
}
