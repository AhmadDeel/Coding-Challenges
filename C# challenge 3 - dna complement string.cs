using System.Linq;
public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            return string.Join("", dna.Select(c => {
                switch (c)
                {
                    case 'A': return 'T';
                    case 'T': return 'A';
                    case 'G': return 'C';
                    case 'C': return 'G';
                    default: return 'a';
                }
            }));
        }
    }