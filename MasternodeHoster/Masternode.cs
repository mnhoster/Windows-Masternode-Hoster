using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasternodeHoster
{
    public class Masternode
    {
        public Masternode()
        {

        }

        public Masternode(int index, string title, string status, string block, int hwnd)
        {
            this.Block = block;
            this.Index = index;
            this.Title = title;
            this.Status = status;
            this.Hwnd = hwnd;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string title;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string status;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private int index;
        public int Hwnd
        {
            get { return hwnd; }
            set { hwnd = value; }
        }
        private int hwnd;
        public string Block
        {
            get { return block; }
            set { block = value; }
        }
        private string block;

        static internal List<Masternode> GetMasternodes(int index, string title, string status, string block, int hwnd, List<Masternode> masternodes)
        {

            //if (Masternode.AllMasternodes.Count == 0)

            
            Masternode.AllMasternodes = Masternode.InitializeSongs( index, title,  status, block, hwnd, masternodes);

                return Masternode.AllMasternodes;

        }
        static private List<Masternode> AllMasternodes = new List<Masternode>();
        static private List<Masternode> InitializeSongs(int index, string title, string status, string block, int hwnd, List<Masternode> masternodes)
        {

            masternodes.Add(new Masternode( index, title, status, block, hwnd));

            //masternodes.Add(new Masternode("Zoo Station", "U2"));
            //masternodes.Add(new Masternode("Who's Gonna Ride Your Wild Horses", "U2", 6301234, "Achtung Baby", 80, new DateTime(2007, 10, 9, 11, 32, 0)));
            //masternodes.Add(new Masternode("So Cruel", "U2", 6901234, "Achtung Baby", 60, new DateTime(2007, 10, 9, 11, 38, 0)));
            //masternodes.Add(new Masternode("The Fly", "U2", 5401234, "Achtung Baby", 60, new DateTime(2007, 10, 9, 11, 42, 0)));
            //masternodes.Add(new Masternode("Tryin' To Throw Your Arms Around The World", "U2", 4701234, "Achtung Baby", 60, new DateTime(2007, 10, 9, 11, 46, 0)));
            //masternodes.Add(new Masternode("Ultraviolet (Light My Way)", "U2", 6601234, "Achtung Baby", 60, new DateTime(2007, 10, 9, 11, 52, 0)));
            //masternodes.Add(new Masternode("Acrobat", "U2", 5401234, "Achtung Baby", 60, new DateTime(2007, 10, 9, 11, 56, 0)));
            //masternodes.Add(new Masternode("Love Is Blindness", "U2", 5301234, "Achtung Baby", 60, new DateTime(2007, 10, 9, 12, 00, 0)));
            //masternodes.Add(new Masternode("Elevation", "U2", 4501234, "All That You Can't Leave Behind", 60, new DateTime(2008, 01, 25, 11, 46, 0)));
            //masternodes.Add(new Masternode("Walk On", "U2", 5801234, "All That You Can't Leave Behind", 100, new DateTime(2008, 03, 18, 11, 39, 0)));
            //masternodes.Add(new Masternode("Kite", "U2", 5201234, "All That You Can't Leave Behind", 40, new DateTime(2008, 01, 23, 10, 36, 0)));
            //masternodes.Add(new Masternode("In A Little While", "U2", 4301234, "All That You Can't Leave Behind", 60, new DateTime(2008, 01, 20, 7, 48, 0)));
            //masternodes.Add(new Masternode("Wild Honey", "U2", 4501234, "All That You Can't Leave Behind", 40, new DateTime(2007, 04, 13, 11, 50, 0)));
            //masternodes.Add(new Masternode("Peace On Earth", "U2", 5601234, "All That You Can't Leave Behind", 40, new DateTime(2007, 12, 22, 2, 51, 0)));
            //masternodes.Add(new Masternode("When I Look At The World", "U2", 5101234, "All That You Can't Leave Behind", 40, new DateTime(2007, 12, 22, 2, 55, 0)));
            //masternodes.Add(new Masternode("New York", "U2", 6401234, "All That You Can't Leave Behind", 60, new DateTime(2007, 12, 22, 3, 01, 0)));
            //masternodes.Add(new Masternode("Grace", "U2", 6501234, "All That You Can't Leave Behind", 40, new DateTime(2007, 12, 22, 3, 06, 0)));
            //masternodes.Add(new Masternode("The Ground Beneath Her Feet(Bonus Masternode)", "U2", 4401234, "All That You Can't Leave Behind", 40, new DateTime(2007, 12, 22, 3, 10, 0)));
            //masternodes.Add(new Masternode("Follow You Home", "Nickelback", 601234, "All The Right Reasons", 40, new DateTime(2008, 03, 6, 10, 42, 0)));
            //masternodes.Add(new Masternode("Fight For All The Wrong Reason", "Nickelback", 5201234, "All The Right Reasons", 60, new DateTime(2008, 03, 15, 5, 04, 0)));
            //masternodes.Add(new Masternode("Photograph", "Nickelback", 601234, "All The Right Reasons", 60, new DateTime(2008, 03, 15, 5, 08, 0)));
            //masternodes.Add(new Masternode("Animals", "Nickelback", 4301234, "All The Right Reasons", 40, new DateTime(2008, 02, 16, 12, 12, 0)));
            //masternodes.Add(new Masternode("Savin' Me", "Nickelback", 5101234, "All The Right Reasons", 80, new DateTime(2008, 03, 24, 10, 41, 0)));
            //masternodes.Add(new Masternode("Far Away", "Nickelback", 5501234, "All The Right Reasons", 40, new DateTime(2008, 03, 15, 5, 30, 0)));
            //masternodes.Add(new Masternode("Next Contestant", "Nickelback", 501234, "All The Right Reasons", 80, new DateTime(2008, 03, 24, 9, 47, 0)));
            //masternodes.Add(new Masternode("Side Of A Bullet", "Nickelback", 4201234, "All The Right Reasons", 40, new DateTime(2008, 03, 6, 11, 00, 0)));
            //masternodes.Add(new Masternode("If Everyone Cared", "Nickelback", 501234, "All The Right Reasons", 60, new DateTime(2008, 03, 6, 11, 03, 0)));
            //masternodes.Add(new Masternode("Someone That You're With", "Nickelback", 5601234, "All The Right Reasons", 40, new DateTime(2008, 02, 16, 12, 34, 0)));
            //masternodes.Add(new Masternode("Rockstar", "Nickelback", 5901234, "All The Right Reasons", 60, new DateTime(2008, 02, 16, 12, 38, 0)));
            //masternodes.Add(new Masternode("Lelani", "Hoodoo Gurus", 5901234, "Ampology", 60, new DateTime(2007, 10, 22, 8, 45, 0)));
            //masternodes.Add(new Masternode("Tojo", "Hoodoo Gurus", 4101234, "Ampology", 60, new DateTime(2007, 10, 22, 8, 48, 0)));
            //masternodes.Add(new Masternode("My Girl", "Hoodoo Gurus", 3301234, "Ampology", 80, new DateTime(2007, 11, 12, 7, 57, 0)));
            //masternodes.Add(new Masternode("Be My Guru", "Hoodoo Gurus", 3301234, "Ampology", 100, new DateTime(2008, 03, 20, 12, 15, 0)));
            //masternodes.Add(new Masternode("I Want You Back", "Hoodoo Gurus", 3901234, "Ampology", 80, new DateTime(2007, 11, 12, 7, 42, 0)));
            //masternodes.Add(new Masternode("I Was A Kamikaze Pilot", "Hoodoo Gurus", 3901234, "Ampology", 60, new DateTime(2007, 10, 22, 9, 00, 0)));
            //masternodes.Add(new Masternode("Bittersweet", "Hoodoo Gurus", 4701234, "Ampology", 60, new DateTime(2007, 10, 22, 9, 04, 0)));
            //masternodes.Add(new Masternode("Poison Pen", "Hoodoo Gurus", 501234, "Ampology", 60, new DateTime(2007, 10, 22, 9, 11, 0)));
            //masternodes.Add(new Masternode("In The Wild", "Hoodoo Gurus", 3901234, "Ampology", 60, new DateTime(2007, 10, 22, 9, 14, 0)));
            //masternodes.Add(new Masternode("Whats My Scene?", "Hoodoo Gurus", 4601234, "Ampology", 100, new DateTime(2007, 11, 12, 7, 51, 0)));
            //masternodes.Add(new Masternode("Heart Of Darkness", "Hoodoo Gurus", 3801234, "Ampology", 60, new DateTime(2007, 10, 22, 9, 21, 0)));
            //masternodes.Add(new Masternode("Good Times", "Hoodoo Gurus", 3701234, "Ampology", 80, new DateTime(2008, 03, 20, 12, 18, 0)));
            //masternodes.Add(new Masternode("Cajun Country", "Hoodoo Gurus", 4901234, "Ampology", 60, new DateTime(2007, 10, 22, 9, 28, 0)));
            //masternodes.Add(new Masternode("Axegrinder", "Hoodoo Gurus", 4201234, "Ampology", 60, new DateTime(2007, 10, 22, 9, 32, 0)));
            //masternodes.Add(new Masternode("Another World", "Hoodoo Gurus", 401234, "Ampology", 80, new DateTime(2008, 03, 20, 12, 21, 0)));
            //masternodes.Add(new Masternode("Meant To Live", "Switchfoot", 401234, "The Beautiful Letdown", 100, new DateTime(2008, 03, 3, 1, 46, 0)));
            //masternodes.Add(new Masternode("This Is Your Life", "Switchfoot", 401234, "The Beautiful Letdown", 100, new DateTime(2008, 03, 3, 2, 11, 0)));
            //masternodes.Add(new Masternode("More than fine", "Switchfoot", 4901234, "The Beautiful Letdown", 60, new DateTime(2008, 03, 3, 2, 16, 0)));
            //masternodes.Add(new Masternode("Ammunition", "Switchfoot", 4401234, "The Beautiful Letdown", 40, new DateTime(2008, 03, 3, 1, 58, 0)));
            //masternodes.Add(new Masternode("Dare you to move", "Switchfoot", 4901234, "The Beautiful Letdown", 80, new DateTime(2008, 03, 3, 2, 20, 0)));
            //masternodes.Add(new Masternode("Redemption", "Switchfoot", 3601234, "The Beautiful Letdown", 80, new DateTime(2008, 03, 19, 5, 19, 0)));
            //masternodes.Add(new Masternode("The beautiful letdown", "Switchfoot", 6201234, "The Beautiful Letdown", 60, new DateTime(2008, 03, 3, 2, 29, 0)));
            //masternodes.Add(new Masternode("Gone", "Switchfoot", 4401234, "The Beautiful Letdown", 80, new DateTime(2008, 03, 3, 2, 33, 0)));
            //masternodes.Add(new Masternode("On Fire", "Switchfoot", 4301234, "The Beautiful Letdown", 80, new DateTime(2008, 03, 3, 2, 37, 0)));
            //masternodes.Add(new Masternode("Adding to the noise", "Switchfoot", 3301234, "The Beautiful Letdown", 60, new DateTime(2008, 03, 19, 5, 42, 0)));
            //masternodes.Add(new Masternode("Twenty-four", "Switchfoot", 5701234, "The Beautiful Letdown", 60, new DateTime(2008, 03, 3, 2, 45, 0)));
            //masternodes.Add(new Masternode("Gap That Opened", "Boom Crash Opera", 4701234, "Boom Crash Opera", 40, new DateTime(2008, 01, 13, 10, 11, 0)));
            //masternodes.Add(new Masternode("Hands Up In The Air", "Boom Crash Opera", 4501234, "Boom Crash Opera", 80, new DateTime(2008, 03, 24, 3, 19, 0)));
            //masternodes.Add(new Masternode("Love Me To Death", "Boom Crash Opera", 5201234, "Boom Crash Opera", 40, new DateTime(2008, 01, 13, 10, 20, 0)));
            //masternodes.Add(new Masternode("City Fist", "Boom Crash Opera", 4901234, "Boom Crash Opera", 40, new DateTime(2008, 01, 13, 10, 24, 0)));
            //masternodes.Add(new Masternode("Her Charity", "Boom Crash Opera", 5801234, "Boom Crash Opera", 40, new DateTime(2008, 01, 13, 10, 29, 0)));
            //masternodes.Add(new Masternode("Sleeping Time", "Boom Crash Opera", 5201234, "Boom Crash Opera", 40, new DateTime(2008, 01, 13, 10, 33, 0)));
            //masternodes.Add(new Masternode("Great Wall", "Boom Crash Opera", 4501234, "Boom Crash Opera", 80, new DateTime(2008, 03, 24, 3, 22, 0)));
            //masternodes.Add(new Masternode("Bombshell", "Boom Crash Opera", 4501234, "Boom Crash Opera", 40, new DateTime(2008, 01, 13, 10, 41, 0)));
            //masternodes.Add(new Masternode("Caught Between Two Towns", "Boom Crash Opera", 401234, "Boom Crash Opera", 40, new DateTime(2008, 01, 13, 10, 44, 0)));
            //masternodes.Add(new Masternode("Too Hot To Think", "Boom Crash Opera", 6301234, "Boom Crash Opera", 40, new DateTime(2008, 01, 13, 10, 50, 0)));
            //masternodes.Add(new Masternode("Starting Today", "Natalie Imbruglia", 6801234, "Counting Down the Days", 0, new DateTime(2008, 03, 19, 9, 48, 0)));
            //masternodes.Add(new Masternode("Shiver", "Natalie Imbruglia", 8601234, "Counting Down the Days", 80, new DateTime(2008, 03, 19, 9, 51, 0)));
            //masternodes.Add(new Masternode("Satisfied", "Natalie Imbruglia", 8101234, "Counting Down the Days", 0, new DateTime(2008, 03, 19, 9, 55, 0)));
            //masternodes.Add(new Masternode("Counting Down the Days", "Natalie Imbruglia", 9601234, "Counting Down the Days", 60, new DateTime(2008, 03, 26, 10, 33, 0)));
            //masternodes.Add(new Masternode("I Won't Be Lost", "Natalie Imbruglia", 901234, "Counting Down the Days", 60, new DateTime(2008, 03, 26, 10, 37, 0)));
            //masternodes.Add(new Masternode("Slow Down", "Natalie Imbruglia", 8101234, "Counting Down the Days", 60, new DateTime(2008, 03, 26, 10, 41, 0)));
            //masternodes.Add(new Masternode("Sanctuary", "Natalie Imbruglia", 7301234, "Counting Down the Days", 60, new DateTime(2008, 03, 26, 10, 44, 0)));
            //masternodes.Add(new Masternode("Perfectly", "Natalie Imbruglia", 7801234, "Counting Down the Days", 80, new DateTime(2008, 03, 26, 10, 47, 0)));
            //masternodes.Add(new Masternode("On the Run", "Natalie Imbruglia", 8401234, "Counting Down the Days", 60, new DateTime(2008, 03, 26, 10, 51, 0)));
            //masternodes.Add(new Masternode("Come on Home", "Natalie Imbruglia", 9101234, "Counting Down the Days", 60, new DateTime(2008, 03, 26, 10, 55, 0)));
            //masternodes.Add(new Masternode("When You're Sleeping", "Natalie Imbruglia", 7201234, "Counting Down the Days", 60, new DateTime(2008, 03, 26, 10, 58, 0)));
            //masternodes.Add(new Masternode("Honeycomb Child", "Natalie Imbruglia", 9801234, "Counting Down the Days", 0, new DateTime(2008, 03, 26, 11, 02, 0)));
            //masternodes.Add(new Masternode("Last Living Souls", "Gorillaz", 4501234, "Demon Days", 80, new DateTime(2008, 01, 12, 9, 55, 0)));
            //masternodes.Add(new Masternode("Kids With Guns", "Gorillaz", 5301234, "Demon Days", 80, new DateTime(2008, 03, 24, 12, 52, 0)));
            //masternodes.Add(new Masternode("O Green World", "Gorillaz", 6301234, "Demon Days", 80, new DateTime(2008, 03, 24, 12, 45, 0)));
            //masternodes.Add(new Masternode("Dirty Harry", "Gorillaz", 5201234, "Demon Days", 80, new DateTime(2008, 03, 24, 12, 48, 0)));
            //masternodes.Add(new Masternode("Feel Good Inc.", "Gorillaz", 5401234, "Demon Days", 100, new DateTime(2008, 03, 24, 1, 07, 0)));
            //masternodes.Add(new Masternode("El Manana", "Gorillaz", 5401234, "Demon Days", 40, new DateTime(2008, 03, 17, 5, 45, 0)));
            //masternodes.Add(new Masternode("Every Plant We Reach Is Dead", "Gorillaz", 6801234, "Demon Days", 80, new DateTime(2008, 03, 24, 12, 57, 0)));
            //masternodes.Add(new Masternode("November Has Come", "Gorillaz", 3801234, "Demon Days", 80, new DateTime(2008, 03, 24, 12, 59, 0)));
            //masternodes.Add(new Masternode("All Alone", "Gorillaz", 4901234, "Demon Days", 80, new DateTime(2008, 01, 12, 9, 49, 0)));
            //masternodes.Add(new Masternode("White Light", "Gorillaz", 301234, "Demon Days", 80, new DateTime(2008, 02, 17, 3, 30, 0)));
            //masternodes.Add(new Masternode("DARE", "Gorillaz", 5701234, "Demon Days", 80, new DateTime(2008, 03, 24, 1, 03, 0)));
            //masternodes.Add(new Masternode("Don't Get Lost In Heaven", "Gorillaz", 2901234, "Demon Days", 80, new DateTime(2008, 03, 24, 12, 36, 0)));
            //masternodes.Add(new Masternode("Demon Days", "Gorillaz", 6301234, "Demon Days", 80, new DateTime(2008, 03, 24, 12, 40, 0)));
            //masternodes.Add(new Masternode("The Pretender", "Foo Fighters", 8301234, "Echoes, Silence, Patience & Grace", 60, new DateTime(2008, 03, 24, 11, 20, 0)));
            //masternodes.Add(new Masternode("Let It Die", "Foo Fighters", 7601234, "Echoes, Silence, Patience & Grace", 40, new DateTime(2008, 03, 24, 11, 24, 0)));
            //masternodes.Add(new Masternode("Erase/Replace", "Foo Fighters", 7801234, "Echoes, Silence, Patience & Grace", 60, new DateTime(2008, 03, 24, 11, 28, 0)));
            //masternodes.Add(new Masternode("Long Road To Ruin", "Foo Fighters", 701234, "Echoes, Silence, Patience & Grace", 60, new DateTime(2008, 03, 24, 11, 31, 0)));
            //masternodes.Add(new Masternode("Come Alive", "Foo Fighters", 9601234, "Echoes, Silence, Patience & Grace", 60, new DateTime(2008, 03, 24, 11, 37, 0)));
            //masternodes.Add(new Masternode("Stranger Things Have Happened", "Foo Fighters", 9901234, "Echoes, Silence, Patience & Grace", 80, new DateTime(2008, 03, 24, 11, 42, 0)));
            //masternodes.Add(new Masternode("Cheer Up, Boys (Your Makeup Is Running)", "Foo Fighters", 6801234, "Echoes, Silence, Patience & Grace", 40, new DateTime(2008, 03, 24, 11, 45, 0)));
            //masternodes.Add(new Masternode("Summer's End", "Foo Fighters", 8601234, "Echoes, Silence, Patience & Grace", 60, new DateTime(2008, 03, 24, 11, 50, 0)));
            //masternodes.Add(new Masternode("The Ballad Of The Beaconsfield", "Foo Fighters", 4701234, "Echoes, Silence, Patience & Grace", 80, new DateTime(2008, 03, 24, 11, 53, 0)));
            //masternodes.Add(new Masternode("Statues", "Foo Fighters", 701234, "Echoes, Silence, Patience & Grace", 60, new DateTime(2008, 03, 24, 11, 57, 0)));
            //masternodes.Add(new Masternode("But, Honestly", "Foo Fighters", 8501234, "Echoes, Silence, Patience & Grace", 40, new DateTime(2008, 03, 24, 12, 01, 0)));
            //masternodes.Add(new Masternode("Home", "Foo Fighters", 901234, "Echoes, Silence, Patience & Grace", 80, new DateTime(2008, 03, 24, 12, 06, 0)));
            //masternodes.Add(new Masternode("Once And For All (Demo) (Bonus Masternode)", "Foo Fighters", 701234, "Echoes, Silence, Patience & Grace", 0, new DateTime(2008, 03, 24, 12, 10, 0)));
            //masternodes.Add(new Masternode("Going Under", "Evanescence", 4201234, "Fallen", 0, new DateTime(2008, 02, 4, 6, 09, 0)));
            //masternodes.Add(new Masternode("Bring Me To Life", "Evanescence", 4601234, "Fallen", 100, new DateTime(2008, 03, 25, 12, 56, 0)));
            //masternodes.Add(new Masternode("Everybody's Fool", "Evanescence", 3801234, "Fallen", 0, new DateTime(2008, 02, 4, 6, 16, 0)));
            //masternodes.Add(new Masternode("Haunted", "Evanescence", 3601234, "Fallen", 0, new DateTime(2008, 02, 4, 6, 19, 0)));
            //masternodes.Add(new Masternode("Tourniquet", "Evanescence", 5401234, "Fallen", 0, new DateTime(2008, 02, 4, 6, 24, 0)));
            //masternodes.Add(new Masternode("Imaginary", "Evanescence", 501234, "Fallen", 0, new DateTime(2008, 02, 4, 6, 28, 0)));
            //masternodes.Add(new Masternode("Taking Over Me", "Evanescence", 4401234, "Fallen", 0, new DateTime(2008, 03, 15, 4, 57, 0)));
            //masternodes.Add(new Masternode("Hello", "Evanescence", 4301234, "Fallen", 0, new DateTime(2008, 02, 4, 6, 35, 0)));
            //masternodes.Add(new Masternode("My Last Breath", "Evanescence", 4801234, "Fallen", 0, new DateTime(2008, 03, 15, 4, 23, 0)));
            //masternodes.Add(new Masternode("Whisper", "Evanescence", 6301234, "Fallen", 0, new DateTime(2008, 02, 4, 6, 45, 0)));
            //masternodes.Add(new Masternode("My Immortal", "Evanescence", 5301234, "Fallen", 0, new DateTime(2008, 02, 4, 6, 50, 0)));
            //masternodes.Add(new Masternode("One-Trick Pony", "Nelly Furtado", 501234, "Folklore", 80, new DateTime(2008, 03, 15, 6, 46, 0)));
            //masternodes.Add(new Masternode("Powerless (Say What You Want)", "Nelly Furtado", 4201234, "Folklore", 80, new DateTime(2008, 03, 15, 6, 50, 0)));
            //masternodes.Add(new Masternode("Explode", "Nelly Furtado", 4101234, "Folklore", 80, new DateTime(2008, 03, 15, 6, 53, 0)));
            //masternodes.Add(new Masternode("Try", "Nelly Furtado", 4901234, "Folklore", 80, new DateTime(2008, 03, 15, 11, 49, 0)));
            //masternodes.Add(new Masternode("Fresh off the Boat", "Nelly Furtado", 3701234, "Folklore", 60, new DateTime(2008, 02, 22, 12, 49, 0)));
            //masternodes.Add(new Masternode("Força", "Nelly Furtado", 401234, "Folklore", 40, new DateTime(2008, 02, 22, 12, 53, 0)));
            //masternodes.Add(new Masternode("The Grass Is Green", "Nelly Furtado", 4201234, "Folklore", 40, new DateTime(2008, 02, 22, 12, 57, 0)));
            //masternodes.Add(new Masternode("Picture Perfect", "Nelly Furtado", 5501234, "Folklore", 40, new DateTime(2008, 01, 19, 12, 08, 0)));
            //masternodes.Add(new Masternode("Saturdays", "Jarvis Church/Nelly Furtado", 2601234, "Folklore", 40, new DateTime(2008, 01, 7, 7, 33, 0)));
            //masternodes.Add(new Masternode("Build You Up", "Nelly Furtado", 5201234, "Folklore", 40, new DateTime(2008, 02, 22, 1, 03, 0)));
            //masternodes.Add(new Masternode("Island of Wonder", "Caetano Veloso/Nelly Furtado", 4201234, "Folklore", 40, new DateTime(2008, 01, 7, 7, 42, 0)));
            //masternodes.Add(new Masternode("The Boy In The Bubble", "Paul Simon", 5601234, "Graceland", 60, new DateTime(2008, 01, 24, 6, 02, 0)));
            //masternodes.Add(new Masternode("Graceland", "Paul Simon", 6701234, "Graceland", 60, new DateTime(2008, 01, 24, 6, 07, 0)));
            //masternodes.Add(new Masternode("I Know What I Know", "Paul Simon", 4501234, "Graceland", 60, new DateTime(2008, 01, 22, 5, 27, 0)));
            //masternodes.Add(new Masternode("Gumboots", "Paul Simon", 3901234, "Graceland", 60, new DateTime(2008, 01, 22, 5, 30, 0)));
            //masternodes.Add(new Masternode("Diamonds On The Soles Of Her Shoes", "Paul Simon", 8101234, "Graceland", 80, new DateTime(2008, 02, 20, 9, 44, 0)));
            //masternodes.Add(new Masternode("You Can Call Me Al", "Paul Simon", 6501234, "Graceland", 60, new DateTime(2008, 01, 22, 5, 40, 0)));
            //masternodes.Add(new Masternode("Under African Skies", "Paul Simon", 5101234, "Graceland", 60, new DateTime(2008, 03, 19, 5, 27, 0)));
            //masternodes.Add(new Masternode("Homeless", "Paul Simon", 5301234, "Graceland", 60, new DateTime(2007, 11, 23, 7, 01, 0)));
            //masternodes.Add(new Masternode("Crazy Love Vol II", "Paul Simon", 601234, "Graceland", 60, new DateTime(2008, 01, 22, 5, 44, 0)));
            //masternodes.Add(new Masternode("That Was Your Mother", "Paul Simon", 4101234, "Graceland", 60, new DateTime(2008, 01, 22, 5, 47, 0)));
            //masternodes.Add(new Masternode("All Around The World Or The Myth of Fingerprints", "Paul Simon", 4601234, "Graceland", 60, new DateTime(2008, 03, 19, 5, 31, 0)));
            //masternodes.Add(new Masternode("Vertigo", "U2", 3801234, "How To Dismantle An Atomic Bomb", 100, new DateTime(2007, 12, 18, 12, 11, 0)));
            //masternodes.Add(new Masternode("Miracle Drug", "U2", 4701234, "How To Dismantle An Atomic Bomb", 100, new DateTime(2008, 03, 19, 12, 04, 0)));
            //masternodes.Add(new Masternode("Sometimes You Can't Make It On Your Own", "U2", 601234, "How To Dismantle An Atomic Bomb", 60, new DateTime(2007, 12, 18, 12, 20, 0)));
            //masternodes.Add(new Masternode("Love And Peace Or Else", "U2", 5601234, "How To Dismantle An Atomic Bomb", 60, new DateTime(2008, 03, 15, 4, 16, 0)));
            //masternodes.Add(new Masternode("City Of Blinding Lights", "U2", 6701234, "How To Dismantle An Atomic Bomb", 80, new DateTime(2008, 03, 19, 12, 10, 0)));
            //masternodes.Add(new Masternode("All Because Of You", "U2", 4301234, "How To Dismantle An Atomic Bomb", 60, new DateTime(2007, 11, 6, 11, 02, 0)));
            //masternodes.Add(new Masternode("A Man And A Woman", "U2", 5301234, "How To Dismantle An Atomic Bomb", 100, new DateTime(2008, 03, 19, 12, 00, 0)));
            //masternodes.Add(new Masternode("Crumbs From Your Table", "U2", 5901234, "How To Dismantle An Atomic Bomb", 60, new DateTime(2007, 11, 6, 11, 12, 0)));
            //masternodes.Add(new Masternode("One Step Closer", "U2", 4501234, "How To Dismantle An Atomic Bomb", 40, new DateTime(2007, 11, 6, 11, 16, 0)));
            //masternodes.Add(new Masternode("Original Of The Species", "U2", 5501234, "How To Dismantle An Atomic Bomb", 40, new DateTime(2007, 11, 6, 11, 20, 0)));
            //masternodes.Add(new Masternode("Yahweh", "U2", 5101234, "How To Dismantle An Atomic Bomb", 80, new DateTime(2008, 03, 18, 11, 56, 0)));
            //masternodes.Add(new Masternode("Grim Travellers", "Bruce Cockburn", 5601234, "Humans", 60, new DateTime(2008, 03, 15, 4, 31, 0)));
            //masternodes.Add(new Masternode("Rumours Of Glory", "Bruce Cockburn", 4301234, "Humans", 80, new DateTime(2008, 03, 25, 1, 25, 0)));
            //masternodes.Add(new Masternode("More Not More", "Bruce Cockburn", 4401234, "Humans", 60, new DateTime(2007, 10, 27, 7, 47, 0)));
            //masternodes.Add(new Masternode("You Get Bigger As You Go", "Bruce Cockburn", 5301234, "Humans", 40, new DateTime(2007, 10, 27, 7, 51, 0)));
            //masternodes.Add(new Masternode("What About The Bond", "Bruce Cockburn", 5701234, "Humans", 40, new DateTime(2007, 10, 27, 7, 56, 0)));
            //masternodes.Add(new Masternode("How I Spent My Fall Vacation", "Bruce Cockburn", 5901234, "Humans", 60, new DateTime(2007, 10, 27, 8, 01, 0)));
            //masternodes.Add(new Masternode("Guerilla Betrayed", "Bruce Cockburn", 4601234, "Humans", 60, new DateTime(2007, 10, 27, 8, 05, 0)));
            //masternodes.Add(new Masternode("Tokyo", "Bruce Cockburn", 4101234, "Humans", 60, new DateTime(2007, 10, 27, 8, 09, 0)));
            //masternodes.Add(new Masternode("Fascist Architecture", "Bruce Cockburn", 3101234, "Humans", 60, new DateTime(2007, 11, 15, 3, 40, 0)));
            //masternodes.Add(new Masternode("The Rose Above The Sky", "Bruce Cockburn", 7401234, "Humans", 80, new DateTime(2008, 03, 25, 1, 22, 0)));
            //masternodes.Add(new Masternode("Torn", "Natalie Imbruglia", 5601234, "Left Of The Middle", 100, new DateTime(2008, 03, 26, 11, 06, 0)));
            //masternodes.Add(new Masternode("One More Addiction", "Natalie Imbruglia", 4901234, "Left Of The Middle", 60, new DateTime(2008, 03, 26, 11, 09, 0)));
            //masternodes.Add(new Masternode("Big Mistake", "Natalie Imbruglia", 6301234, "Left Of The Middle", 80, new DateTime(2008, 03, 26, 11, 14, 0)));
            //masternodes.Add(new Masternode("Leave Me Alone", "Natalie Imbruglia", 601234, "Left Of The Middle", 60, new DateTime(2008, 03, 26, 11, 18, 0)));
            //masternodes.Add(new Masternode("Wishing I Was There", "Natalie Imbruglia", 5301234, "Left Of The Middle", 80, new DateTime(2008, 03, 26, 11, 22, 0)));
            //masternodes.Add(new Masternode("Smoke", "Natalie Imbruglia", 6401234, "Left Of The Middle", 60, new DateTime(2008, 03, 26, 11, 26, 0)));
            //masternodes.Add(new Masternode("Pigeons And Crumbs", "Natalie Imbruglia", 7401234, "Left Of The Middle", 0, new DateTime(2008, 03, 26, 11, 32, 0)));
            //masternodes.Add(new Masternode("Don't You Think", "Natalie Imbruglia", 5401234, "Left Of The Middle", 80, new DateTime(2008, 03, 26, 11, 36, 0)));
            //masternodes.Add(new Masternode("Impressed", "Natalie Imbruglia", 6601234, "Left Of The Middle", 80, new DateTime(2008, 03, 26, 11, 40, 0)));
            //masternodes.Add(new Masternode("Intuition", "Natalie Imbruglia", 4701234, "Left Of The Middle", 80, new DateTime(2008, 03, 26, 11, 44, 0)));
            //masternodes.Add(new Masternode("City", "Natalie Imbruglia", 6301234, "Left Of The Middle", 0, new DateTime(2008, 03, 26, 11, 48, 0)));
            //masternodes.Add(new Masternode("Left Of The Middle", "Natalie Imbruglia", 5201234, "Left Of The Middle", 60, new DateTime(2008, 03, 26, 11, 52, 0)));
            //masternodes.Add(new Masternode("Life For Rent", "Dido", 4301234, "Life For Rent", 80, new DateTime(2008, 02, 20, 9, 35, 0)));
            //masternodes.Add(new Masternode("Mary's In India", "Dido", 4301234, "Life For Rent", 80, new DateTime(2008, 02, 20, 9, 39, 0)));
            //masternodes.Add(new Masternode("See You When You're 40", "Dido", 6201234, "Life For Rent", 80, new DateTime(2008, 02, 20, 9, 15, 0)));
            //masternodes.Add(new Masternode("Don't Leave Home", "Dido", 4401234, "Life For Rent", 80, new DateTime(2008, 02, 20, 9, 31, 0)));
            //masternodes.Add(new Masternode("Who Makes You Feel", "Dido", 5101234, "Life For Rent", 80, new DateTime(2008, 02, 20, 9, 09, 0)));
            //masternodes.Add(new Masternode("Sand In My Shoes", "Dido", 5801234, "Life For Rent", 80, new DateTime(2008, 02, 20, 9, 24, 0)));
            //masternodes.Add(new Masternode("Do You Have A Little Time", "Dido", 4601234, "Life For Rent", 80, new DateTime(2008, 02, 20, 9, 19, 0)));
            //masternodes.Add(new Masternode("This Land Is Mine", "Dido", 4401234, "Life For Rent", 80, new DateTime(2008, 02, 20, 9, 27, 0)));
            //masternodes.Add(new Masternode("See The Sun", "Dido", 10123422, "Life For Rent", 60, new DateTime(2007, 12, 22, 10, 28, 0)));
            //masternodes.Add(new Masternode("Lifesong", "Casting Crowns", 4901234, "Lifesong", 80, new DateTime(2008, 03, 24, 2, 36, 0)));
            //masternodes.Add(new Masternode("Praise You in This Storm", "Casting Crowns", 4601234, "Lifesong", 100, new DateTime(2008, 03, 24, 2, 17, 0)));
            //masternodes.Add(new Masternode("Does Anybody Hear Her", "Casting Crowns", 4201234, "Lifesong", 60, new DateTime(2007, 12, 26, 3, 07, 0)));
            //masternodes.Add(new Masternode("Stained Glass Masquerade", "Casting Crowns", 3601234, "Lifesong", 60, new DateTime(2007, 12, 26, 3, 11, 0)));
            //masternodes.Add(new Masternode("Love Them Like Jesus", "Casting Crowns", 4201234, "Lifesong", 60, new DateTime(2007, 11, 4, 3, 00, 0)));
            //masternodes.Add(new Masternode("Set Me Free", "Casting Crowns", 4101234, "Lifesong", 80, new DateTime(2008, 03, 24, 2, 12, 0)));
            //masternodes.Add(new Masternode("While You Were Sleeping", "Casting Crowns", 4501234, "Lifesong", 60, new DateTime(2008, 01, 1, 12, 39, 0)));
            //masternodes.Add(new Masternode("Father, Spirit, Jesus", "Casting Crowns", 4801234, "Lifesong", 80, new DateTime(2008, 03, 24, 2, 41, 0)));
            //masternodes.Add(new Masternode("In Me", "Casting Crowns", 4401234, "Lifesong", 80, new DateTime(2008, 03, 24, 2, 31, 0)));
            //masternodes.Add(new Masternode("Prodigal", "Casting Crowns", 5301234, "Lifesong", 60, new DateTime(2007, 12, 26, 3, 36, 0)));
            //masternodes.Add(new Masternode("And Now My Lifesong Sings", "Casting Crowns", 3801234, "Lifesong", 60, new DateTime(2008, 01, 1, 12, 54, 0)));
            //masternodes.Add(new Masternode("Afraid", "Nelly Furtado", 3301234, "Loose", 80, new DateTime(2008, 03, 15, 11, 41, 0)));
            //masternodes.Add(new Masternode("Maneater", "Nelly Furtado", 4101234, "Loose", 40, new DateTime(2008, 01, 19, 12, 20, 0)));
            //masternodes.Add(new Masternode("Promiscuous", "Nelly Furtado", 3701234, "Loose", 60, new DateTime(2008, 01, 21, 5, 01, 0)));
            //masternodes.Add(new Masternode("Glow", "Nelly Furtado", 3701234, "Loose", 80, new DateTime(2008, 03, 15, 11, 45, 0)));
            //masternodes.Add(new Masternode("Showtime", "Nelly Furtado", 3901234, "Loose", 80, new DateTime(2008, 03, 15, 6, 37, 0)));
            //masternodes.Add(new Masternode("No Hay Igual", "Nelly Furtado", 3301234, "Loose", 80, new DateTime(2008, 03, 15, 11, 33, 0)));
            //masternodes.Add(new Masternode("Te Busque", "Nelly Furtado", 3401234, "Loose", 60, new DateTime(2008, 01, 21, 5, 17, 0)));
            //masternodes.Add(new Masternode("Say It Right", "Nelly Furtado", 3401234, "Loose", 60, new DateTime(2008, 01, 21, 5, 21, 0)));
            //masternodes.Add(new Masternode("Do It", "Nelly Furtado", 3401234, "Loose", 60, new DateTime(2008, 01, 21, 5, 24, 0)));
            //masternodes.Add(new Masternode("In God's Hands", "Nelly Furtado", 4501234, "Loose", 40, new DateTime(2008, 01, 21, 5, 29, 0)));
            //masternodes.Add(new Masternode("Wait for You", "Nelly Furtado", 4801234, "Loose", 40, new DateTime(2008, 01, 21, 5, 34, 0)));
            //masternodes.Add(new Masternode("Somebody to Love", "Nelly Furtado", 4601234, "Loose", 40, new DateTime(2008, 01, 21, 5, 39, 0)));
            //masternodes.Add(new Masternode("All Good Things (Come to an End)", "Nelly Furtado", 4801234, "Loose", 40, new DateTime(2008, 01, 21, 5, 44, 0)));
            //masternodes.Add(new Masternode("Someone Somewhere In Summertime", "Simple Minds", 6501234, "New Gold Gream (81/82/83/84)", 60, new DateTime(2007, 09, 1, 9, 11, 0)));
            //masternodes.Add(new Masternode("Colours Fly And Catherine Wheel", "Simple Minds", 5401234, "New Gold Gream (81/82/83/84)", 80, new DateTime(2007, 11, 19, 8, 34, 0)));
            //masternodes.Add(new Masternode("Big Sleep", "Simple Minds", 6901234, "New Gold Gream (81/82/83/84)", 40, new DateTime(2007, 09, 1, 9, 20, 0)));
            //masternodes.Add(new Masternode("Somebody Up There Likes You", "Simple Minds", 701234, "New Gold Gream (81/82/83/84)", 40, new DateTime(2007, 09, 1, 9, 25, 0)));
            //masternodes.Add(new Masternode("New Gold Dream (81-82-83-84)", "Simple Minds", 7901234, "New Gold Gream (81/82/83/84)", 60, new DateTime(2007, 09, 1, 9, 30, 0)));
            //masternodes.Add(new Masternode("Glittering Prize", "Simple Minds", 6401234, "New Gold Gream (81/82/83/84)", 60, new DateTime(2007, 08, 13, 8, 24, 0)));
            //masternodes.Add(new Masternode("Hunter And The Hunted", "Simple Minds", 8301234, "New Gold Gream (81/82/83/84)", 60, new DateTime(2007, 08, 13, 8, 30, 0)));
            //masternodes.Add(new Masternode("King Is White And In The Crowd", "Simple Minds", 9701234, "New Gold Gream (81/82/83/84)", 20, new DateTime(2007, 08, 13, 8, 37, 0)));
            //masternodes.Add(new Masternode("Promised you a miracle", "Simple Minds", 4701234, "New Gold Gream (81/82/83/84)", 40, new DateTime(2008, 01, 10, 12, 01, 0)));
            //masternodes.Add(new Masternode("Psycho Killer", "Talking Heads", 5201234, "Once In A Lifetime", 40, new DateTime(2008, 02, 4, 5, 06, 0)));
            //masternodes.Add(new Masternode("Take Me To The River", "Talking Heads", 601234, "Once In A Lifetime", 40, new DateTime(2008, 02, 4, 5, 11, 0)));
            //masternodes.Add(new Masternode("Once In A Lifetime", "Talking Heads", 5201234, "Once In A Lifetime", 80, new DateTime(2008, 02, 4, 5, 15, 0)));
            //masternodes.Add(new Masternode("Burning Down The House", "Talking Heads", 4801234, "Once In A Lifetime", 100, new DateTime(2008, 02, 10, 12, 19, 0)));
            //masternodes.Add(new Masternode("This Must Be The Place (Naive Melody)", "Talking Heads", 5901234, "Once In A Lifetime", 40, new DateTime(2008, 02, 4, 5, 24, 0)));
            //masternodes.Add(new Masternode("Slippery People (Live)", "Talking Heads", 5101234, "Once In A Lifetime", 40, new DateTime(2008, 02, 4, 5, 28, 0)));
            //masternodes.Add(new Masternode("Life During Wartime (Live)", "Talking Heads", 601234, "Once In A Lifetime", 40, new DateTime(2008, 02, 4, 5, 34, 0)));
            //masternodes.Add(new Masternode("And She Was", "Talking Heads", 4401234, "Once In A Lifetime", 60, new DateTime(2008, 02, 4, 5, 37, 0)));
            //masternodes.Add(new Masternode("Road To Nowhere", "Talking Heads", 5201234, "Once In A Lifetime", 80, new DateTime(2008, 02, 4, 5, 42, 0)));
            //masternodes.Add(new Masternode("Wild Wild Life", "Talking Heads", 4401234, "Once In A Lifetime", 60, new DateTime(2008, 02, 4, 5, 45, 0)));
            //masternodes.Add(new Masternode("Blind", "Talking Heads", 5901234, "Once In A Lifetime", 40, new DateTime(2008, 02, 4, 5, 50, 0)));
            //masternodes.Add(new Masternode("(Nothing But) Flowers", "Talking Heads", 6601234, "Once In A Lifetime", 40, new DateTime(2008, 02, 4, 5, 56, 0)));
            //masternodes.Add(new Masternode("Sax And Violins", "Talking Heads", 6301234, "Once In A Lifetime", 60, new DateTime(2008, 02, 4, 6, 01, 0)));
            //masternodes.Add(new Masternode("Lifetime Piling Up", "Talking Heads", 4601234, "Once In A Lifetime", 80, new DateTime(2008, 02, 4, 6, 05, 0)));
            //masternodes.Add(new Masternode("Honey", "Moby", 4801234, "Play", 80, new DateTime(2008, 02, 22, 10, 59, 0)));
            //masternodes.Add(new Masternode("Find My Baby", "Moby", 5501234, "Play", 60, new DateTime(2008, 02, 22, 11, 03, 0)));
            //masternodes.Add(new Masternode("Porcelain", "Moby", 5601234, "Play", 40, new DateTime(2008, 03, 14, 11, 34, 0)));
            //masternodes.Add(new Masternode("Why Does My Heart Feel So Bad?", "Moby", 6101234, "Play", 80, new DateTime(2008, 02, 22, 11, 12, 0)));
            //masternodes.Add(new Masternode("Southside", "Moby", 5301234, "Play", 80, new DateTime(2008, 03, 3, 4, 20, 0)));
            //masternodes.Add(new Masternode("Rushing", "Moby", 4201234, "Play", 60, new DateTime(2008, 03, 14, 11, 30, 0)));
            //masternodes.Add(new Masternode("Bodyrock", "Moby", 501234, "Play", 100, new DateTime(2008, 03, 14, 11, 27, 0)));
            //masternodes.Add(new Masternode("Natural Blues", "Moby", 5901234, "Play", 40, new DateTime(2008, 02, 22, 11, 27, 0)));
            //masternodes.Add(new Masternode("Machete", "Moby", 5101234, "Play", 20, new DateTime(2008, 02, 22, 11, 30, 0)));
            //masternodes.Add(new Masternode("7", "Moby", 1501234, "Play", 20, new DateTime(2008, 03, 14, 11, 23, 0)));
            //masternodes.Add(new Masternode("Run On", "Moby", 5201234, "Play", 40, new DateTime(2008, 03, 19, 5, 52, 0)));
            //masternodes.Add(new Masternode("Down Slow", "Moby", 2201234, "Play", 40, new DateTime(2008, 03, 14, 11, 22, 0)));
            //masternodes.Add(new Masternode("If Things Were Perfect", "Moby", 601234, "Play", 60, new DateTime(2008, 02, 22, 11, 40, 0)));
            //masternodes.Add(new Masternode("Everloving", "Moby", 4801234, "Play", 40, new DateTime(2007, 12, 27, 11, 06, 0)));
            //masternodes.Add(new Masternode("Inside", "Moby", 6701234, "Play", 60, new DateTime(2007, 12, 27, 11, 10, 0)));
            //masternodes.Add(new Masternode("Guitar Flute And String", "Moby", 301234, "Play", 60, new DateTime(2007, 12, 27, 11, 12, 0)));
            //masternodes.Add(new Masternode("The Sky Is Broken", "Moby", 601234, "Play", 60, new DateTime(2007, 11, 4, 2, 22, 0)));
            //masternodes.Add(new Masternode("My Weakness", "Moby", 501234, "Play", 40, new DateTime(2007, 11, 4, 2, 26, 0)));
            //masternodes.Add(new Masternode("Discotheque", "U2", 6101234, "Pop", 100, new DateTime(2008, 03, 3, 4, 16, 0)));
            //masternodes.Add(new Masternode("Do You Feel Loved", "U2", 5901234, "Pop", 60, new DateTime(2008, 02, 7, 11, 04, 0)));
            //masternodes.Add(new Masternode("Mofo", "U2", 6701234, "Pop", 60, new DateTime(2008, 02, 7, 11, 10, 0)));
            //masternodes.Add(new Masternode("If God Will Send His Angels", "U2", 6201234, "Pop", 80, new DateTime(2008, 02, 7, 11, 16, 0)));
            //masternodes.Add(new Masternode("Staring At The Sun", "U2", 5301234, "Pop", 80, new DateTime(2008, 03, 19, 12, 15, 0)));
            //masternodes.Add(new Masternode("Last Night On Earth", "U2", 5501234, "Pop", 100, new DateTime(2008, 02, 7, 11, 25, 0)));
            //masternodes.Add(new Masternode("Gone", "U2", 5101234, "Pop", 60, new DateTime(2008, 02, 7, 11, 29, 0)));
            //masternodes.Add(new Masternode("Miami", "U2", 5601234, "Pop", 40, new DateTime(2007, 11, 14, 5, 53, 0)));
            //masternodes.Add(new Masternode("The Playboy Mansion", "U2", 5401234, "Pop", 40, new DateTime(2007, 11, 14, 5, 58, 0)));
            //masternodes.Add(new Masternode("If You Wear That Velvet Dress", "U2", 6101234, "Pop", 60, new DateTime(2007, 11, 14, 6, 03, 0)));
            //masternodes.Add(new Masternode("Please", "U2", 5801234, "Pop", 40, new DateTime(2008, 02, 6, 11, 28, 0)));
            //masternodes.Add(new Masternode("Wake Up Dead Man", "U2", 5601234, "Pop", 40, new DateTime(2008, 02, 6, 11, 20, 0)));
            //masternodes.Add(new Masternode("The River", "Live", 4101234, "Masternodes From Black Mountain", 80, new DateTime(2008, 03, 24, 10, 55, 0)));
            //masternodes.Add(new Masternode("Mystery", "Live", 5201234, "Masternodes From Black Mountain", 80, new DateTime(2008, 03, 24, 10, 59, 0)));
            //masternodes.Add(new Masternode("Get Ready", "Live", 4901234, "Masternodes From Black Mountain", 60, new DateTime(2008, 03, 23, 1, 02, 0)));
            //masternodes.Add(new Masternode("Show", "Live", 4701234, "Masternodes From Black Mountain", 80, new DateTime(2008, 03, 24, 11, 03, 0)));
            //masternodes.Add(new Masternode("Wings", "Live", 5301234, "Masternodes From Black Mountain", 0, new DateTime(2008, 03, 23, 1, 09, 0)));
            //masternodes.Add(new Masternode("Sofia", "Live", 5401234, "Masternodes From Black Mountain", 0, new DateTime(2008, 03, 23, 1, 13, 0)));
            //masternodes.Add(new Masternode("Love Shines (A Masternode For My Daughters About God)", "Live", 4601234, "Masternodes From Black Mountain", 0, new DateTime(2008, 03, 23, 1, 16, 0)));
            //masternodes.Add(new Masternode("Where Do We Go From Here", "Live", 5201234, "Masternodes From Black Mountain", 0, new DateTime(2008, 03, 23, 1, 20, 0)));
            //masternodes.Add(new Masternode("Home", "Live", 4701234, "Masternodes From Black Mountain", 0, new DateTime(2008, 03, 23, 1, 23, 0)));
            //masternodes.Add(new Masternode("All I Need", "Live", 4501234, "Masternodes From Black Mountain", 0, new DateTime(2008, 03, 23, 1, 26, 0)));
            //masternodes.Add(new Masternode("You Are Not Alone", "Live", 5201234, "Masternodes From Black Mountain", 0, new DateTime(2008, 02, 19, 12, 05, 0)));
            //masternodes.Add(new Masternode("Night Of Nights", "Live", 4901234, "Masternodes From Black Mountain", 0, new DateTime(2008, 02, 19, 12, 08, 0)));
            //masternodes.Add(new Masternode("All For Believing", "Missy Higgins", 4201234, "The Sound Of White", 80, new DateTime(2008, 01, 30, 4, 21, 0)));
            //masternodes.Add(new Masternode("Don't Ever", "Missy Higgins", 3501234, "The Sound Of White", 40, new DateTime(2008, 01, 30, 4, 24, 0)));
            //masternodes.Add(new Masternode("Scar", "Missy Higgins", 4301234, "The Sound Of White", 80, new DateTime(2008, 01, 30, 4, 28, 0)));
            //masternodes.Add(new Masternode("Ten Days", "Missy Higgins", 4501234, "The Sound Of White", 80, new DateTime(2008, 01, 30, 5, 10, 0)));
            //masternodes.Add(new Masternode("Nightminds", "Missy Higgins", 401234, "The Sound Of White", 60, new DateTime(2008, 01, 30, 5, 13, 0)));
            //masternodes.Add(new Masternode("Casualty", "Missy Higgins", 501234, "The Sound Of White", 60, new DateTime(2008, 03, 15, 4, 43, 0)));
            //masternodes.Add(new Masternode("Any Day Now", "Missy Higgins", 4601234, "The Sound Of White", 60, new DateTime(2007, 12, 30, 2, 35, 0)));
            //masternodes.Add(new Masternode("Katie", "Missy Higgins", 4301234, "The Sound Of White", 60, new DateTime(2007, 12, 30, 2, 38, 0)));
            //masternodes.Add(new Masternode("The River", "Missy Higgins", 5301234, "The Sound Of White", 60, new DateTime(2007, 11, 16, 9, 06, 0)));
            //masternodes.Add(new Masternode("The Special Two", "Missy Higgins", 5201234, "The Sound Of White", 100, new DateTime(2008, 01, 30, 5, 18, 0)));
            //masternodes.Add(new Masternode("This Is How It Goes", "Missy Higgins", 4201234, "The Sound Of White", 60, new DateTime(2008, 01, 30, 5, 22, 0)));
            //masternodes.Add(new Masternode("The Sound Of White", "Missy Higgins", 5701234, "The Sound Of White", 80, new DateTime(2008, 01, 30, 5, 27, 0)));
            //masternodes.Add(new Masternode("They Weren't There", "Missy Higgins", 4901234, "The Sound Of White", 60, new DateTime(2007, 12, 30, 2, 56, 0)));

            return masternodes;
        }
    }
    
}
