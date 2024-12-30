using UnityEngine;
namespace Assignment26
{


    public class Duck : Creature, IRunnable, ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck run");
        }
        public void Swim()
        {
            Debug.Log("Duck swim");
        }
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }
}