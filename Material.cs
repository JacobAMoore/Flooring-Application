using System;
using System.Text;

namespace FinalSemesterProject
{
    public class Material
    {
	   public Material(string name, string desc, decimal price)
	   {
		  Name = name;
		  Desc = desc;
		  Price = price;
	   }

	   public string Name { get; set; }
	   public string Desc { get; set; }
	   public decimal Price { get; set; }
	   public double Length { get; set; }
	   public double Width { get; set; }
	   public Boolean Installed { get; set; }
	   public decimal Labor { get; set; }

	   //implemented methods regarding the materials properties
	   public decimal GetCost => (decimal)Area* Price;
	   public double Area => Length * Width;
	   public double AreaSqYards => Area * 0.111;
	   public decimal LaborCost => Labor * (decimal)AreaSqYards;
	   public decimal TotalCost => GetCost + Labor;

	   //the overriden ToString for our class
	   public override string ToString()
	   {
		  return Name + " " + Desc + " " + Price;
	   }

	   public string ToStringDetail()
	   {
		    StringBuilder sb = new StringBuilder();
		    sb.AppendFormat("{0, -13}: {1, 10}\n", "Flooring Name ", Name);
			sb.AppendLine();
            sb.AppendFormat("{0, -13}: {1, 10}\n", "Desc          ", Desc);
			sb.AppendLine();
            sb.AppendFormat("{0, -13}: {1, 10:C}\n", "Price       ", Price);
			sb.AppendLine();
            sb.AppendFormat("{0, -13}: {1, 10:N0}\n", "Area(ft)   ", Area);
			sb.AppendLine();
            sb.AppendFormat("{0, -13}: {1, 10:N0}\n", "Area(yd)   ", AreaSqYards);
			sb.AppendLine();
            sb.AppendFormat("{0, -13}: {1, 10:C}\n", "Cost        ", GetCost);
			sb.AppendLine();
            sb.AppendFormat("{0, -13}: {1, 10:C}\n", "Installation", Labor);
			sb.AppendLine();
            sb.AppendFormat("{0, -13}: {1, 10:C}\n", "Total Price", TotalCost);
		    return sb.ToString();


        }



    }
}
