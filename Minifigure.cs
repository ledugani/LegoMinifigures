using LegoMinifigures.Heads;

namespace LegoMinifigures
{
    class Minifigure
    {
        private readonly HeadBase _head;

        public Minifigure(HeadBase head)
        {
            _head = head;
        }

        public void DoStuff()
        {
            _head.Talk();
            _head.Eat();
        }
    }
}
