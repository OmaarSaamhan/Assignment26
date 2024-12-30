using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{

    public class CreatureManager : MonoBehaviour
    {
        Kangaroo kangaroo;
        Duck duck;
        void Start()
        {
            List<Creature> creatures = new List<Creature>();
            creatures.Add(kangaroo = new Kangaroo());
            creatures.Add(duck = new Duck());

            List<IRunnable> runnables = new List<IRunnable>();
            List<IJumpable> jumpables = new List<IJumpable>();
            List<ISwimmable> swimmables = new List<ISwimmable>();

            runnables.Add(kangaroo);
            jumpables.Add(kangaroo);

            runnables.Add(duck);
            swimmables.Add(duck);

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }
            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }
            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }
            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }
        }

    }
}
