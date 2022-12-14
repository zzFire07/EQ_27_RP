namespace RoleplayGame
{
    public class Wizard : MagicCharacters, IHeroes
    {
        public SpellsBook spellsBook { get; set; } = new SpellsBook();

        public Wizard(string name) : base(name)
        {
            Staff staff = new Staff();

            this.EquipItem(staff);
            spellsBook.AddSpell();
            this.EquipItem(spellsBook);
        }
    }
}