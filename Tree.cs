using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tree : Plant, IPriceable
{
    private decimal price;

    public Tree(string name, string about, decimal price)
    {
        Name = name;
        About = about;
        this.price = price;
    }

    public override string Name { get; }
    public override string About { get; }

    public override int Count { get; set; }

    public decimal Get_Price()
    {
        return price;
    }
}
