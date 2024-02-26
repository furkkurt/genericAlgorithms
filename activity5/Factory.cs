using System;
using System.Collections.Generic;
using algorithms;

namespace activity5
{
    static class Factory
    {
        public static object Find(this object[] vector, string query, IEqualsPredicate e)
        {
            if (query.EndsWith("*"))
            {
                query = query.Substring(0, query.Length - 1);
                for (int i = 0; i < vector.Length; i++)
                {
                    if (e.CompareToStartsWith(vector[i].ToString(), query))
                    {
                        return vector[i].ToString();
                    }
                }
            }
            else if (query.StartsWith("*"))
            {
                query = query.Substring(1);
                for (int i = 0; i < vector.Length; i++)
                {
                    //Console.WriteLine(query);
                    if (e.CompareToEndsWith(vector[i].ToString(), query))
                    {
                        return vector[i].ToString();
                    }
                }
            }
            else
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    //Console.WriteLine(query);
                    if (e.CompareToContaines(vector[i].ToString(), query))
                    {
                        return vector[i].ToString();
                    }
                }
            }
            return null;
        }

        public static System.Collections.Generic.List<object> Filter(this object[] vector, string query, IEqualsPredicate e)
        {
            var res = new List<object>();

            if (query.EndsWith("*"))
            {
                query = query.Substring(0, query.Length - 1);
                for (int i = 0; i < vector.Length; i++)
                {
                    if (e.CompareToStartsWith(vector[i].ToString(), query))
                    {
                        res.Add(vector[i].ToString());
                    }
                }
            }
            else if (query.StartsWith("*"))
            {
                query = query.Substring(1);
                for (int i = 0; i < vector.Length; i++)
                {
                    //Console.WriteLine(query);
                    if (e.CompareToEndsWith(vector[i].ToString(), query))
                    {
                        res.Add(vector[i].ToString());
                    }
                }
            }
            else
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    //Console.WriteLine(query);
                    if (e.CompareToContaines(vector[i].ToString(), query))
                    {
                        res.Add(vector[i].ToString());
                    }
                }
            }

            return res;
        }


        static Person[] CreatePeople()
        {
            string[] firstnames = { "María", "Juan", "Pepe", "Luis", "Carlos", "Miguel", "Cristina" };
            string[] surnames = { "Díaz", "Pérez", "Hevia", "García", "Rodríguez", "Pérez", "Sánchez" };
            int numberOfPeople = 100;

            Person[] printOut = new Person[numberOfPeople];
            Random random = new Random();
            for (int i = 0; i < numberOfPeople; i++)
                printOut[i] = new Person(
                    firstnames[random.Next(0, firstnames.Length)],
                    surnames[random.Next(0, surnames.Length)],
                    random.Next(9000000, 90000000) + "-" + (char)random.Next('A', 'Z')
                    );
            return printOut;
        }

        static Angle[] CreateAngles()
        {
            Angle[] angles = new Angle[(int)(Math.PI * 2 * 10)];
            int i = 0;
            while (i < angles.Length)
            {
                angles[i] = new Angle(i / 10.0);
                i++;
            }

            return angles;
        }

        static void Main()
        {
            Person[] people = CreatePeople();
            Person maria = new Person("María", "Kurt", "123");
            people[3] = maria;
            Console.WriteLine(Find(people, "M*", new PersonNameComparator()));

            Angle[] angles = CreateAngles();
            Angle pi = new Angle(Math.PI);
            angles[3] = pi;
            Console.WriteLine(Find(angles, "*180", new AngleComparator()));
        }
    }
}
