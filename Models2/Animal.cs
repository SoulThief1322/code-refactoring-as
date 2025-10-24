namespace Namespace
{
    public class Animal
    {
        public int id;
        public string Namez;
        public string OwNer;
        public int agee;
        public string typee;
        public bool sickOrNot = false;
        public string notezz = "";

        public void MakeOlder()
        {
            agee += 3;
        }

        public void Heal()
        {
            sickOrNot = false;
            notezz = "feeling ok i guess";
        }
    }
}