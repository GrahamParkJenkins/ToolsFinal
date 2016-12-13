using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace FinalProcessor_GrahamPark_259907
{
    public class Process
    {


        String[] mLines;

        public List<Vector3> mVectors = new List<Vector3>();

        public void GetVectors()
        {
            mVectors.Clear();
            string path;

            int timesThrough = 0;

            float nX = 0, nY = 0, nZ = 0;

            string mCurrent = "";

            Vector3 mTempVect = new Vector3();

            path = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\TheVectors.txt");

            mLines = File.ReadAllLines(path);

            foreach (string line in mLines)
            {
                mCurrent = "";
                timesThrough = 0;
                foreach (char mChar in line)
                {
                    if(mChar == ',' || mChar == ')')
                    {

                        if(timesThrough == 0)
                        {
                            nX = Convert.ToSingle(mCurrent);
                        }
                        else if(timesThrough == 1)
                        {
                            nY = Convert.ToSingle(mCurrent);
                        }
                        else if (timesThrough == 2)
                        {
                            nZ = Convert.ToSingle(mCurrent);
                        }

                        mCurrent = "";
                        timesThrough++;
                    }
                    else if(mChar != '(')
                    {
                            mCurrent += mChar;
                    }

                }

                mTempVect = new Vector3(nX, nY, nZ);

                //Console.WriteLine(mTempVect.x + "," + mTempVect.y + "," + mTempVect.z);

                mVectors.Add(mTempVect);


            }

            //foreach (Vector3 item in mVectors)
            //{
            //    Console.WriteLine(item.x + "," + item.y + "," + item.z);
            //}
            //Console.ReadKey();
        }


        public void SortVectors(float margin)
        {
            for (int i = 0; i < mVectors.Count; i++)
            {
                for (int j = i + 1; j < mVectors.Count;)

                {
                    //Console.ReadKey();
                    if (mVectors[i].GetDistanceFrom(mVectors[j]) <= margin)
                    {
                        mVectors.Remove(mVectors[j]);
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }

        public void CreateOutputFile()
        {
            string line = "";
            using (StreamWriter file =
            new StreamWriter(Directory.GetCurrentDirectory() + @"\Output.txt", true))
            {
                foreach (Vector3 vect in mVectors)
                {
                    line = "(" + vect.x + "," + vect.y + "," + vect.z + ")";
                    file.WriteLine(line);
                }
            }
        }

        //Console.WriteLine(mVectors[j].x + "," + mVectors[j].y + "," + mVectors[j].z);


    }
}
