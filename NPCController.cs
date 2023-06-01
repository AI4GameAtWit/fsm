public class NPCController : MonoBehaviour
{
    public GameObject player;
    public NPCState currentState = NPCState.Patrol;
    private float distanceToPlayer;
    public float attackDistance = 10f;
    public float retreatDistance = 20f;
    
    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);

        switch (currentState)
        {
            case NPCState.Patrol:
                // Code to move the NPC in a patrol pattern here

                if (distanceToPlayer <= attackDistance)
                {
                    currentState = NPCState.Attack;
                }
                break;

            case NPCState.Attack:
                // Code to make the NPC attack the player here

                if (distanceToPlayer > attackDistance)
                {
                    currentState = NPCState.Patrol;
                }
                else if (distanceToPlayer <= retreatDistance)
                {
                    currentState = NPCState.Retreat;
                }
                break;

            case NPCState.Retreat:
                // Code to make the NPC move away from the player here

                if (distanceToPlayer > retreatDistance)
                {
                    currentState = NPCState.Patrol;
                }
                break;
        }
    }
}
