using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2ESpellBook
{
    public class NewSpellEntry : IEnumerable<NewSpellEntry>
    {
        List<NewSpellEntry> newSpellEntries;

        public IEnumerator<NewSpellEntry> GetEnumerator()
        {
            return newSpellEntries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string Name { get; set; }
        public string Ability { get; set; }
        public string Area { get; set; }
        public string AreaType { get; set; }
        public string AutoHeightenLevel { get; set; }
        public string Category { get; set; }
        public string Component_focus { get; set; }
        public string Component_material { get; set; }
        public string Component_somatic  { get; set; }
        public string Component_verbal { get; set; }
        public string Components { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string HasCounteractCheck { get; set; }
        public string Level { get; set; }
        public string Location { get; set; }
        public string Materials { get; set; }
        public string Prepared { get; set; }
        public string Range { get; set; }
        public string Rules { get; set; }
        public string Resistances { get; set; }
        public string CharacterGains { get; set; }
        public string Save_Basic { get; set; }
        public string Save_Value { get; set; }
        public string School { get; set; }
        public string SpellType { get; set; }
        public string Sustained { get; set; }
        public string Target { get; set; }
        public string Time { get; set; }
        public string Traditions { get; set; }
        public string Traits { get; set; }
        public string Effects { get; set; }
    }
}
