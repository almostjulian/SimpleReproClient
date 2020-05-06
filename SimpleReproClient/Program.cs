using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Extensions;
using System;
using System.Net;

namespace SimpleReproClient
{
    class Program
    {
        static void Main(string[] args)
        {

            var usernames = new string[] {
    "aerationmortar",
    "badgecopperfield",
    "coathangerquisby",
    "mistyoutlying",
    "steamparakeet",
    "subtletykonkeys",
    "distortcona",
    "snorkelkiloparsec",
    "contexttubes",
    "wipeoutfinishing",
    "tallysexy",
    "threefoldloud",
    "appeardelete",
    "saltysaligo",
    "elixirnurturing",
    "junkmantuesday",
    "widthflick",
    "scrollradial",
    "concernchowder",
    "chimpledsailor",
    "boffeerae",
    "shelterespresso",
    "crimdonearshot",
    "millchimps",
    "voucherseminole",
    "gullibleracism",
    "coveylammle",
    "kiteatmosphere",
    "optimisticzabra",
    "unpackboltrope",
    "confusedoriginally",
    "delegatetreat",
    "projectorunhappy",
    "stayforegoing",
    "caliengaged",
    "gostscord",
    "birkdaleacid",
    "ponderelfishly",
    "emblematicascertain",
    "unsignedchuck",
    "pumpedmobal",
    "henhambridgemost",
    "mosedalerejoice",
    "linguistshobby",
    "starlesswhether",
    "bullfinchedrupal",
    "majorfolk",
    "murphylurch",
    "cummerbundlena",
    "theaterjuly",
    "wavecondone",
    "unfiteclipse",
    "plugbyarkansas",
    "channellazy",
    "donordapper",
    "extraneousfog",
    "kleenexandroid",
    "retouchboar",
    "revivalsnoopy",
    "pettinessplage",
    "ruddermower",
    "gritevacuation",
    "coffleunsorted",
    "furiouscasablanca",
    "gynecologyservlet",
    "slingshotslace",
    "celerypark",
    "razslinging",
    "cimarronwest",
    "lathereddefiant",
    "tuitionwiggling",
    "putridblow",
    "bellpizz",
    "packageshredding",
    "twisterundrafted",
    "savorscorecard",
    "studentmap",
    "maxwellprice",
    "bumharmony",
    "cockalorumgazelle",
    "adoptedmusty",
    "rashesgold",
    "joulesidekick",
    "wheeringnightjar",
    "albumvolary",
    "kengemicroscope",
    "lustrouscadillac",
    "garbagenear",
    "rubbingchance",
    "koiledprogram",
    "ashtonalias",
    "dykethieving",
    "pegboardcaviar",
    "pseudomerlyn",
    "shimmeringpostbox",
    "censusfruit",
    "carbondrag",
    "scarywistful",
    "busybodyspur",
    "flangebleep",
    "oldponcho",
    "foyerhefty",
    "warrencurliness",
    "steerforthdizziness",
    "challengeiodine",
    "relightwornout",
    "riverevidence",
    "jarbidgeskating",
    "neuronobedient",
    "dartgoldmedal",
    "serveengland",
    "flashlightwilliam",
    "harmfrustrate",
    "luckdegrading",
    "skulkaxiom",
    "fuzzydreary",
    "chategetaway",
    "elvisminimum",
    "auditoriumegotism",
    "lyingtypical",
    "ruttishgravel",
    "assemblypicassa",
    "partnersesame",
    "staticvacancies",
    "unhiddenmilitary",
    "visorouter",
    "gummyjury",
    "jerkycanopener",
    "cringlefinical",
    "obviousritual",
    "remotedownstairs",
    "effectsquartic",
    "unevensimplify",
    "radfootdisk",
    "safehousefluorine",
    "hybridisland",
    "frothdeeno",
    "familycured",
    "stuporcrest",
    "nicotinebrigadier",
    "rowingaltruistic",
    "copyeel",
    "beginnerend",
    "moneylesspredefine",
    "lowlandmedland",
    "brewertimid",
    "genesauctions",
    "shearflora",
    "shrewdmost",
    "unlovablemachine",
    "concernslugged",
    "umpirestiggling",
    "heftinessannouncer",
    "borummight",
    "sanguinespotting",
    "reggaetweezers",
    "subsetprecision",
    "romapenalty",
    "muppetrequest",
    "yuckyskaters",
    "swillpear",
    "dubniumdivulge",
    "hoffrenewably",
    "eustaticslide",
    "ecologytess",
    "erringtyke",
    "buydates",
    "funeralswin",
    "onstagetacky",
    "frizzyamendable",
    "urbanpatch",
    "managerpanting",
    "shenyangpersecute",
    "monthsrelated",
    "oilyduct",
    "nephewcold",
    "refinishpersevere",
    "crunchyreflective",
    "sartorialpetch",
    "flashbulbdevious",
    "consentpoach",
    "layoutlook",
    "purifywinking",
    "unusedstirring",
    "recallcreed",
    "offjab",
    "itemizerregain",
    "apparelshoveler",
    "gongoozleluckily",
    "skeletalblade",
    "unsureumber",
    "recognizetiming",
    "scamrising",
    "freeganjasper",
    "internationalfeisty",
    "identicalstale",
    "positivesitcom",
    "initialdike",
    "stalestarboard",
    "dwellingjule"
            };

            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            var client = new RestClient("https://localhost:44354");

            foreach (var user in usernames)
            {
                var request = new RestRequest($"users/{user}.json");                
                var response = client.Get(request);
                Console.WriteLine($"Requested URL: {response.ResponseUri}");

                try
                {
                    dynamic obj = JToken.Parse(response.Content);

                    Console.WriteLine($"{obj.userName} {obj.firstName} {obj.LastName}");

                }
                catch (JsonReaderException jex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    Console.ResetColor();
                }
                catch (Exception ex) //some other exception
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                    Console.ResetColor();
                }


            }
        }
    }
}
