using System.Collections;

namespace newProject02
{
    internal class Program
    {

        static string[] readFile(String file)
        {
            string[] lines = File.ReadAllLines(file);
            return lines;
        }

        static ArrayList isEven(string[] list)
        {
            ArrayList array = new ArrayList();
            foreach (string line in list)
            {
             
                int newElement = int.Parse(line);
                if(newElement %2 == 0)
                {
                    array.Add(newElement);
                }
            }
            return array;
        }

        static ArrayList checkValues(string[] list)
        {
            ArrayList array = new ArrayList();
            // Sprawdzam każdy element w liście 
            foreach(string line in list)
            {
                int sum1 = 0;
                int sum2 = 0;

                // pętllą for przechodzę przez elementy stringa 
                // dla substringa od 0 do 2 sumuję w zmiennej sum1 
                // dla substringa od 3 do 6 sumuję z zmiennej sum2
                for (int i = 0; i < line.Length; i++)
                {
                    if(i < 3)
                    {
                        int number = int.Parse(line.Substring(i, 1));
                        sum1 = sum1 + number;
                    }
                    else {
                        int number = int.Parse(line.Substring(i, 1));
                        sum2 = sum2 + number;
                    }
                    
                }
                // porównuję zmienne - jeżeli sum1 jest więszę to dodaję całość do listy 
                if (sum1 > sum2)
                {
                    array.Add(line);
                }
            }

            return array;
        }



        static void Main(string[] args)
        {
            Number n = new Number();

            Number.a = 10;

        }



    }


    
}