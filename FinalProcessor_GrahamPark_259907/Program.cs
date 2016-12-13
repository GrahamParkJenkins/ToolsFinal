using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProcessor_GrahamPark_259907
{
    class Program
    {
        static void Main(string[] args)
        {
            float mMargin = 4.0f;

            Process mProcess = new Process();

            mProcess.GetVectors();


            mProcess.SortVectors(mMargin);


            mProcess.CreateOutputFile();

        }
    }
}
