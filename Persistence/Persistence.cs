
using Newtonsoft.Json;

namespace Sistema_contable
{
    public class Persist
    {
        private const string PersistenceFile = "blockchain.json";
        public static bool PersistBlockchain(Blockchain blockchain)
        {
            try
            {
                string blockchainJson = JsonConvert.SerializeObject(blockchain, (Newtonsoft.Json.Formatting)Formatting.Indented);
                File.WriteAllText(PersistenceFile, blockchainJson);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static Blockchain ReadBlockchain()
        {
            try
            {
                if (File.Exists(PersistenceFile))
                {
                    string blockchainJson = File.ReadAllText(PersistenceFile);
                    return JsonConvert.DeserializeObject<Blockchain>(blockchainJson);
                }
                else
                {
                    return new Blockchain();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Blockchain();
            }
        }
    }
}