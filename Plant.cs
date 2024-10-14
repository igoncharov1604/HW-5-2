using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Plant : IPlant, ICountable
{
    public abstract string Name { get; }
    public abstract string About { get; }

    public abstract int Count { get; set; }
}
