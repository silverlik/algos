using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = System.IO.File.ReadLines(@"..\..\input.txt").ToArray();
            int n; 
            if(!int.TryParse(num[0], out n)||
                n <= 0 || n > 1000) return;
            var data = num[1].Split(' ');
            var input = new List<int>(); 
            foreach(var d in data)
            {
                input.Add(int.Parse(d));
            }
            var output = new List<int>();
         //   var tempo = new List<string>();
            int place = 1; output.Add(place);
            int temp;
            
            for(int j=1; j<n; j++)
            {
        //        tempo.Add(j+ " : before " + string.Join(" ", input));
                for (int i=j-1; i>=0; i--)
                {   
                    place = i+2;
                    if (input[i] <= input[i + 1]) break;
                
                    temp = input[i + 1];
                    input[i+1] = input[i];
                    input[i] = temp;
                    place = i+1;
                }
          //      tempo.Add(string.Join(" ", input)+ " place = " + place + " j:"+ j);
                output.Add(place);
            }
            System.IO.File.WriteAllText(@"..\..\output.txt", string.Join(" ", output) + Environment.NewLine + string.Join(" ", input));
        }
    }
}
