using UnityEngine;
namespace Assignment26
{

    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound");
        }


    }
    public interface IRunnable
    {
        public void Run();
    }
    public interface IJumpable
    {
        public void Jump();
    }
    public interface ISwimmable
    {
        public void Swim();
    }
}