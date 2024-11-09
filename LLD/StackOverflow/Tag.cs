using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    public class Tag
    {
        public int Id { get; }
        public string Name { get; }

        public Tag(string name)
        {
            Id = GenerateId();
            Name = name;
        }

        private int GenerateId()
        {
            return (int)(DateTime.Now.Ticks % int.MaxValue);
        }
    }
}
