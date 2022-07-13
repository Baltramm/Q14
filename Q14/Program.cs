using System;
using System.Collections.Generic;
using System.Linq;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
{
   1,
   "Сергей ",
   "Андрей ",
   300,
};
            var selectedObjects = (from p in objects where p is string orderby p select p);
            foreach (var Objects in selectedObjects)
                Console.WriteLine(Objects);
            foreach (var selectedObj in objects.Where(a => a is string).OrderBy(a => a))
                Console.WriteLine(selectedObj);
        }
    }
}
