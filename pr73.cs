using System;

namespace Proga
{
    interface Test
    {
        void TestMethod() { }
    }
    interface IAction : Test
    {
        void Fly();
    }
    abstract class Animal : IAction
    {
        public abstract void Fly();
    }
    abstract class Bird : Animal, IAction
    {
        public override void Fly() => Console.WriteLine("fly");
    }
    internal class Prog
    {
        static void Main(string[] args)
        {
        }
    }
}
