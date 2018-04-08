using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostNumerousPenguin {
	class Program {
		static void Main(string[] args) {
			string mostNumerous1 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin" });
			string mostNumerous2 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Little Penguin", "Emperor Penguin", "Macaroni Penguin", "Macaroni Penguin", "Little Penguin" });
			Console.WriteLine(mostNumerous1);
			Console.WriteLine(mostNumerous2);

			Console.ReadLine();
		}

		static string GetMostNumerous(string[] penguins) {
            int ep = 0;
            int mp = 0;
            int lp = 0;
            for (int y = 0; y < penguins.Length; y++) {
                if (penguins[y] == "Emperor Penguin")
                {
                    ep = ep + 1;
                }
                if (penguins[y] == "Macaroni Penguin")
                {
                    mp = mp + 1;
                }
                if (penguins[y] == "Litlle Penguin")
                {
                    lp = lp + 1;
                }
            }    
                if (ep > mp && ep > lp)
                {
                    return "Emperor penguin";
                }
                if (mp > ep && mp > lp)
                {
                    return "Macoroni penguin";
                }
                if (lp > ep && lp > mp)
                {
                    return "Litlle penguin";
                }            

			return ""; 
		}
	}
}
