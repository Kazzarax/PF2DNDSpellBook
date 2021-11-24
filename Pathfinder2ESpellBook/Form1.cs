
namespace Pathfinder2ESpellBook
{
    using System;
    using System.IO;
    using Newtonsoft.Json;
    using System.Windows.Forms;
    using BuildSpellBook;
    using static BuildSpellBook.SpellEntry;
    using System.Data;
    using System.Text.RegularExpressions;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string showFolderPicker()
        {
            var savePath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                savePath = fbd.SelectedPath;
            }
            return savePath;
        }

        public string MatchRegex(string source, string pattern)
        {
            
            Regex rgx_CritSuccess = new Regex(pattern, RegexOptions.IgnoreCase);
            var match = rgx_CritSuccess.Match(source);
            return match.ToString();
        }

        public string RemoveFromString(string source, string pattern)
        {
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            var match = rgx.Replace(source, "");
            return match;
        }


        public void LoadJSON()
        {
            var savePath = showFolderPicker();
            savePath += "\\Pathfinder_2E_SpellBook_" + DateTime.Now.ToString("yyyyMMddhhmmss");
            var fn = savePath + ".csv";
            string jsonFilePath = @"C:\\Users\\Chris\\Desktop\\SpellJSON.json";
            string json = File.ReadAllText(jsonFilePath);
            SpellEntry spells = new SpellEntry();
            Rootobject obj = JsonConvert.DeserializeObject<Rootobject>(json);
            var totalSpellCount = obj.count;
            var currentSpellCount = 0;
            if (!File.Exists(fn))
            {
                using (StreamWriter sw = File.CreateText(fn))
                {
                    sw.WriteLine("Name" + "|" + "Level" + "|" + "Category" + "|" + "Traditions" +"|" + "Area" + "|" + "Range" + "|" + "Target" + "|" + "Duration" + "|" + "CastTime/AP" + "|" + "CharacterGains" + "|" + "TargetGains" + "|" + "Save_Basic" + "|" + "Save_Type" + "|" + "Materials" + "|" + "Prepared" + "|" + "Components" + "|" + "Traits" + "|" + "HasCounteractCheck" + "|" + "School" + "|" + "Sustained" + "|" +  "Critical Success" + "|" + "Success" + "|" + "Failure" + "|" + "CritFailure" + "|" + "Description");
                }
            }
            foreach (var spell in obj.results)
            {
                var name = "";
                var area = "";
                var areatype = "";
                var category = "";
                var component_focus = "";
                var component_material = "";
                var component_somatic = "";
                var component_verbal = "";
                var components = "";
                var description = "";
                var criticalsuccess = "";
                var success = "";
                var failure = "";
                var criticalfailure = "";
                var duration = "";
                var hascounteractcheck = "";
                var level = "";
                var materials = "";
                var prepared = "";
                var range = "";
                var charactergains = "";
                var save_basic = "";
                var save_value = "";
                var school = "";
                var sustained = "";
                var target = "";
                var time = "";
                var traditions = "";
                var traits = "";
                var targeteffect = "";

                currentSpellCount += 1;

                Utils.Try(() => name = spell.name.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => area = spell.data.area.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => areatype = spell.data.area.areaType.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => category = spell.data.category.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => component_focus = spell.data.components.focus.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => component_material = spell.data.components.material.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => component_somatic = spell.data.components.somatic.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => component_verbal= spell.data.components.verbal.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => duration = spell.data.duration.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => hascounteractcheck = spell.data.hasCounteractCheck.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => level = spell.data.level.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => materials = spell.data.materials.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => prepared = spell.data.prepared.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => range = spell.data.range.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => save_basic = spell.data.save.basic.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => save_value = spell.data.save.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => school = spell.data.school.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => sustained = spell.data.sustained.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => target = spell.data.target.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => time = spell.data.time.value.ToString().Replace("|", "_").Replace("\n", ""));
                Utils.Try(() => description = spell.data.description.value.ToString().Replace("|", "_").Replace("\n", "").Replace("'", ""));


                if (name == "Vampiric Maiden") 
                {
                    var x = 1;
                }



                area = (area == "" ? "" : area + "(ft)");
                components = (component_focus == "False" ? "" : "Focus");
                components += (component_material == "False" ? "" : (components == "" ? "Material" : ", Material"));
                components += (component_somatic == "False" ? "" : (components == "" ? "Somatic" : ", Somatic"));
                components += (component_verbal == "False" ? "" : (components == "" ? "Verbal" : ", Verbal"));
                description = RemoveFromString(description, "\\<\\/?(?:\\w|\\w+)\\>");
                description = RemoveFromString(description, "<span class=\"pf2-icon\">");
                description = RemoveFromString(description, "\\<\\/?(?:\\w|\\w+)\\s?\\/?\\>");
                criticalsuccess = MatchRegex(description, "Critical Success\\:?(?:\\s\\w+)+.");
                success = MatchRegex(description, "Success\\:?(?<!Critical Success)(?:\\s\\w+)+.");
                failure = MatchRegex(description, "Failure\\:?(?<!Critical Failure)(?:\\s\\w+)+.");
                criticalfailure = MatchRegex(description, "Critical Failure\\:?(?:\\s\\w+)+.");
                

                string[] trad = spell.data.traditions.value;
                foreach (var t in trad)
                {
                    traditions = (traditions == "" ? t.ToString() : traditions + ", " + t.ToString());
                }
                string[] traitsstring = spell.data.traits.value;
                foreach (var x in traitsstring)
                {
                    traits = (traits == "" ? x.ToString() : traits + ", " + x.ToString());
                }
                
                //Extract 'Character Gains'
                string[] gainParts = description.Split('.');
                foreach (var gnpart in gainParts)
                {
                    Regex gainrgx = new Regex("(you (gain|lose|loose))", RegexOptions.IgnoreCase);                    
                    var match = gainrgx.Match(gnpart);
                    if (match.Length > 0)
                    {
                        var x = MatchRegex(gnpart, "(C?r?i?t?i?c?a?l? ?(?:Success|Failure))");
                        if (x.Length == 0)
                        { 
                            charactergains = (charactergains == "" ? gnpart : charactergains + ", " + gnpart);
                        }
                    }

                }

                string[] targetgainsParts = description.Split('.');
                foreach (var tarpart in targetgainsParts)
                {
                    if(tarpart != charactergains) 
                    {
                        Regex gainrgx = new Regex("target takes", RegexOptions.IgnoreCase);
                        var match = gainrgx.Match(tarpart);
                        if (match.Length > 0)
                        { var x = MatchRegex(tarpart, "(C?r?i?t?i?c?a?l? ?(?:Success|Failure))");
                            if (x.Length == 0)
                            {
                                targeteffect = (targeteffect == "" ? tarpart : targeteffect + ", " + tarpart);
                            }
                        }
                    }
                }
                spellLoadingText.Invoke(new Action(() => { spellLoadingText.Text = "Currently Writing Spell " + currentSpellCount + " of " + totalSpellCount + "."; }));                
                File.AppendAllText(fn,Environment.NewLine + name + "|" + level + "|" + category + "|"+ traditions + " | " + area +" "+areatype + "|" + range + "|" + target + "|" + duration + "|" + time + "|" + charactergains + "|" + targeteffect + "|" + save_basic + "|" + save_value + "|" + materials + "|" + prepared + "|" + components + "|" + traits + "|" + hascounteractcheck + "|" + school + "|" + sustained + "|" + criticalsuccess + "|" + success + "|" + failure + "|" + criticalfailure + "|" + description);

            }
            MessageBox.Show("File Created at: " + savePath + ".csv");
        }
           
        public static DataTable MakeSpellTable(DataTable dt)
        {
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Area", typeof(string));
            dt.Columns.Add("AreaType", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Component_focus", typeof(string));
            dt.Columns.Add("Component_material", typeof(string));
            dt.Columns.Add("Component_somatic ", typeof(string));
            dt.Columns.Add("Component_verbal", typeof(string));
            dt.Columns.Add("Components", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("CriticalSuccess", typeof(string));
            dt.Columns.Add("Success", typeof(string));
            dt.Columns.Add("Failure", typeof(string));
            dt.Columns.Add("CriticalFailure", typeof(string));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("HasCounteractCheck", typeof(string));
            dt.Columns.Add("Level", typeof(string));
            dt.Columns.Add("Materials", typeof(string));
            dt.Columns.Add("Prepared", typeof(string));
            dt.Columns.Add("Range", typeof(string));
            dt.Columns.Add("CharacterGains", typeof(string));
            dt.Columns.Add("Save_Basic", typeof(string));
            dt.Columns.Add("Save_Value", typeof(string));
            dt.Columns.Add("School", typeof(string));
            dt.Columns.Add("SpellType", typeof(string));
            dt.Columns.Add("Sustained", typeof(string));
            dt.Columns.Add("Target", typeof(string));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Traditions", typeof(string));
            dt.Columns.Add("Traits", typeof(string));
            return dt;
        }

        private void LoadSpellData_Click(object sender, EventArgs e)
        {
            LoadJSON();
        }

        public delegate void VoidDelegate();

        public static class Utils
        {
            public static void Try(VoidDelegate v)
            {
                try
                {
                    v();
                }
                catch {}
            }
        }


    }
}
