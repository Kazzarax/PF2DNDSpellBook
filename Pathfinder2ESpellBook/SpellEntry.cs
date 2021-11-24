using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSpellBook
{
    class SpellEntry
    {
        public class Rootobject
        {
            public int count { get; set; }
            public Result[] results { get; set; }
        }

        public class Result
        {
            public string _id { get; set; }
            public Data data { get; set; }
            public object[] effects { get; set; }
            public string name { get; set; }
            public string type { get; set; }
        }

        public class Data
        {
            public Ability ability { get; set; }
            public Area area { get; set; }
            public Autoheightenlevel autoHeightenLevel { get; set; }
            public Category category { get; set; }
            public Components components { get; set; }
            public Cost cost { get; set; }
            public Description description { get; set; }
            public Duration duration { get; set; }
            public Hascounteractcheck hasCounteractCheck { get; set; }
            public Level level { get; set; }
            public Location location { get; set; }
            public Materials materials { get; set; }
            public Prepared prepared { get; set; }
            public Range range { get; set; }
            public Rule[] rules { get; set; }
            public Save save { get; set; }
            public School school { get; set; }
            public Source source { get; set; }
            public Spelltype spellType { get; set; }
            public Sustained sustained { get; set; }
            public Target target { get; set; }
            public Time time { get; set; }
            public Traditions traditions { get; set; }
            public Traits traits { get; set; }
            public Areasize areasize { get; set; }
            public Primarycheck primarycheck { get; set; }
            public Secondarycasters secondarycasters { get; set; }
            public Secondarycheck secondarycheck { get; set; }
            public Damage damage { get; set; }
            public Scaling scaling { get; set; }
            public Areatype areatype { get; set; }
            public Damagetype damageType { get; set; }
            public Rarity1 rarity { get; set; }
            public Spellcategorie spellCategorie { get; set; }
            public Usage usage { get; set; }
        }

        public class Ability
        {
            public string value { get; set; }
        }

        public class Area
        {
            public string areaType { get; set; }
            public object value { get; set; }
        }

        public class Autoheightenlevel
        {
            public object value { get; set; }
        }

        public class Category
        {
            public string value { get; set; }
        }

        public class Components
        {
            public bool focus { get; set; }
            public bool material { get; set; }
            public bool somatic { get; set; }
            public bool verbal { get; set; }
            public string value { get; set; }
        }

        public class Cost
        {
            public string value { get; set; }
        }

        public class Description
        {
            public string value { get; set; }
        }

        public class Duration
        {
            public string value { get; set; }
        }

        public class Hascounteractcheck
        {
            public bool value { get; set; }
        }

        public class Level
        {
            public int value { get; set; }
        }

        public class Location
        {
            public object value { get; set; }
        }

        public class Materials
        {
            public string value { get; set; }
        }

        public class Prepared
        {
            public object value { get; set; }
        }

        public class Range
        {
            public string value { get; set; }
        }

        public class Save
        {
            public string basic { get; set; }
            public string value { get; set; }
        }

        public class School
        {
            public string value { get; set; }
        }

        public class Source
        {
            public string value { get; set; }
        }

        public class Spelltype
        {
            public string value { get; set; }
        }

        public class Sustained
        {
            public bool value { get; set; }
        }

        public class Target
        {
            public string value { get; set; }
        }

        public class Time
        {
            public string value { get; set; }
        }

        public class Traditions
        {
            public string custom { get; set; }
            public string[] value { get; set; }
        }

        public class Traits
        {
            public string custom { get; set; }
            public Rarity rarity { get; set; }
            public string[] value { get; set; }
            public object selected { get; set; }
        }

        public class Rarity
        {
            public string value { get; set; }
        }

        public class Areasize
        {
            public string value { get; set; }
        }

        public class Primarycheck
        {
            public string value { get; set; }
        }

        public class Secondarycasters
        {
            public string value { get; set; }
        }

        public class Secondarycheck
        {
            public string value { get; set; }
        }

        public class Damage
        {
            public object value { get; set; }
            public bool applyMod { get; set; }
        }

        public class Scaling
        {
            public Damage1 damage { get; set; }
            public int interval { get; set; }
        }

        public class Damage1
        {
            public string _0 { get; set; }
            public string _1 { get; set; }
            public string gftav8gvt4i3mqj6 { get; set; }
            public string v1pnjhfu6e9akqe0 { get; set; }
            public string _2 { get; set; }
            public string _3 { get; set; }
            public string j69kf1nfy3b1xton { get; set; }
        }

        public class Areatype
        {
            public string value { get; set; }
        }

        public class Damagetype
        {
            public string value { get; set; }
        }

        public class Rarity1
        {
            public string value { get; set; }
        }

        public class Spellcategorie
        {
            public string value { get; set; }
        }

        public class Usage
        {
            public string value { get; set; }
        }

        public class Rule
        {
            public string key { get; set; }
            public string label { get; set; }
            public string property { get; set; }
            public Predicate predicate { get; set; }
            public string selector { get; set; }
            public string type { get; set; }
            public object value { get; set; }
            public string mode { get; set; }
            public string path { get; set; }
            public int priority { get; set; }
        }

        public class Predicate
        {
            public string[] all { get; set; }
        }

    }
}
