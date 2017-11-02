using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var MVA = from artist in Artists 
            where artist.Hometown == "Mount Vernon" 
            select new {artist.ArtistName, artist.RealName};

            //Who is the youngest artist in our collection of artists?
            var Allyoungest = from artist in Artists
            orderby artist.Age ascending
            select new {artist.ArtistName, artist.Age};

            var Theyoungest = Allyoungest.Take(1);

            //Display all artists with 'William' somewhere in their real name
            var Wills = from artist in Artists
            where artist.RealName.Contains("William")
            select new {artist.ArtistName, artist.RealName};

            //Display the 3 oldest artist from Atlanta
            var Alloldest = from artist in Artists
            orderby artist.Age descending
            where artist.Hometown == "Atlanta"
            select new{artist.ArtistName, artist.Age};

            var Theoldest = Alloldest.Take(3);
            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            var NonNYC = from artist in Artists
            where artist.Hometown != "New York City"
            join squad in Groups on artist.Group.Id equals squad.Id
            select new {squad.GroupName};
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            var ProtectYaNeck = from squad in Groups
            where squad.GroupName == "Wu Tang Clan"
            join artist in Artists on squad.Id equals artist.GroupId
            select new {artist.ArtistName, artist.RealName, squad.GroupName};
        }
    }
}
