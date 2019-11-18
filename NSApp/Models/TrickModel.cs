using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSApp.Models
{
    public class TrickModel
    {
        public string Name { get; set; }
        public List<TrickRequirement> Requirements { get; set; }
        public string Info { get; set; }
        public string Description { get; set; }
        public string Working { get; set; }
    }

    public class TricksModel
    {
        public List<TrickModel> Tricks;
    }

    public class TrickRequirement
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
