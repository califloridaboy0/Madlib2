using System;
namespace Madlib2
{
    public class SentChoice
    {
        public static string SentChoice1()
        {
           int x = Convert.ToInt32(Console.ReadLine()) - 1;

            string[] Sent1; //ends with thing1
            Sent1 = new string[3];
            Sent1[0] = "We will always choose our favorite ";
            Sent1[1] = "Many times, we all eat the same ";
            Sent1[2] = "I love my ";

            return(Sent1[x]);
        }

        public static string SentChoice2()
        {
            int x = Convert.ToInt32(Console.ReadLine()) - 1;

            string[] Sent2 = new string[3]; //starts with celeb1 and ends with anml1
            Sent2[0] = " has always wanted to ride a ";
            Sent2[1] = " often dreams of dancing with a ";
            Sent2[2] = " has nightmares about coming face to face with a ";

            return (Sent2[x]);
        }

        public static string SentChoice3pt1()
        {
            int x = Convert.ToInt32(Console.ReadLine()) - 1;

            string[] Sent3pt1 = new string[3]; //verb1 in middle, pt2, plthing on end
            Sent3pt1[0] = "Often, we ";
            Sent3pt1[1] = "I could never ";
            Sent3pt1[2] = "Many times, the dog will ";

            return (Sent3pt1[x]);
        }

        public static string SentChoice3pt2()
        {
            int x = Convert.ToInt32(Console.ReadLine()) - 1;

            string[] Sent3pt2 = new string[3]; //ends with plthing
            Sent3pt2[0] = " over ";
            Sent3pt2[1] = " with ";
            Sent3pt2[2] = " next to the ";

            return (Sent3pt2[x]);

        }
    }
}
