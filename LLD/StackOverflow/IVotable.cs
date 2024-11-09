using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    public interface IVotable
    {
        void Vote(User user, int value);
        int GetVoteCount();
    }
}
