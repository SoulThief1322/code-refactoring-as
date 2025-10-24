namespace CodeRefactoring.Data.Models
{
    public class Animal
    {
        public int Id;
        public string Names = string.Empty;
        public string Owner = string.Empty;
        public int Age;
        public string Type = string.Empty;
        public bool IsSick = false;
        public string Notes = "";

        public void MakeOlder()
        {
            Age += 3;
        }

        public void Heal()
        {
            IsSick = false;
            Notes = "feeling ok i guess";
        }
    }
}