using UnityEngine;
using System.Collections;

public class CloudGenerator : MonoBehaviour
{
    public Rain rain;

    float SPAWN_INTERVAL = 0.025f; // How much time until the next particle spawns
    float lastSpawnTime = float.MinValue; //The last spawn time
    public int PARTICLE_LIFETIME = 3; //How much time will each particle live
    public Vector3 particleForce; //Is there a initial force particles should have?
    public DynamicParticle.STATES particlesState = DynamicParticle.STATES.WATER; // The state of the particles spawned
    public Transform particlesParent; // Where will the spawned particles will be parented (To avoid covering the whole inspector with them)

    void Start()
    {

        rain = this.GetComponent<Rain>();
    }

    void Update()
    {
        switch (rain.state)
        {
            case WaterState.Frozen:
                particlesState = DynamicParticle.STATES.ICE;
                break;
            case WaterState.Liquid:
                particlesState = DynamicParticle.STATES.WATER;
                break;
            case WaterState.Steam:
                particlesState = DynamicParticle.STATES.GAS;
                break;
        }


        if (lastSpawnTime + SPAWN_INTERVAL < Time.time)
        { // Is it time already for spawning a new particle?
            GameObject newParticle = (GameObject)Instantiate(Resources.Load("LiquidPhysics/DynamicParticle")); //Spawn a particle
            newParticle.GetComponent<Rigidbody2D>().AddForce(particleForce); //Add our custom force
            DynamicParticle particleScript = newParticle.GetComponent<DynamicParticle>(); // Get the particle script
            particleScript.SetLifeTime(PARTICLE_LIFETIME); //Set each particle lifetime
            particleScript.SetState(particlesState); //Set the particle State
            newParticle.transform.position = transform.position;// Relocate to the spawner position

            Vector3 cloudRange = new Vector3(Random.Range(-2f, 2f), 0, 0);
            newParticle.transform.Translate(cloudRange);

            newParticle.transform.parent = particlesParent;// Add the particle to the parent container			
            lastSpawnTime = Time.time; // Register the last spawnTime			
        }
    }
}
