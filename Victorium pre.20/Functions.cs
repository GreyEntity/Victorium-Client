using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Victorium_pre_2._0
{
    class Functions
    {
        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            foreach (FileInfo file in new DirectoryInfo(Folder).GetFiles(FileType))
                lsb.Items.Add((object)file.Name);
        }
        //CURRENTLY UNDER DEVELOPMENT
        public static string[] TextToBox =
{
            //Commands [0]
            "\n" +
            "Commands:\n" +
            "ff [p]\n" +
            "heaven [p]\n" +
            "ghost [p]\n" +
            "statchange [p] [stat] [#]\n" +
            "keemstar [p]\n" +
            "illuminati [p]\n" +
            "duck [p]\n" +
            "mlg [p]\n" +
            "pussy [p]\n" +
            "fog [#]\n" +
            "rfog\n" +
            "rhat [p]\n" +
            "ws [p] [#]\n" +
            "sit [p]\n" +
            "hipheight [p] [#]\n" +
            "jp [p] [#]\n" +
            "kill [p]\n" +
            "drivebloxmoney [p]\n" +
            "gravity [#]\n" +
            "btools [p]\n" +
            "god [p]\n" +
            "bigfire [p]\n" +
            "time [#]\n" +
            "select [p]\n" +
            "fencingr\n" +
            "forcechat [p] [blue/red/green]\n" +
            "charapp [p] [#]\n" +
            "noob [p]\n" +
            "fire [p]\n" +
            "smoke [p]\n" +
            "sethealth [p] [#]\n" +
            "addhealth [p] [#]\n" +
            "sparkles [p]\n" +
            "criminal\n" +
            "garage\n" +
            "bank\n" +
            "prison\n" +
            "nodoors\n" +
            "banklazers\n" +
            "jewelrycameras\n" +
            "jewelrylazers\n" +
            "jewelryflazers\n" +
            "jewelry\n" +
            "rickroll\n" +
            "ppap\n" +
            "billnye\n" +
            "illuminati\n" +
            "rage\n" +
            "cringe\n" +
            "clearws\n" +
            "unanchorall\n" +
            "fecheck\n" +
            "play [#]\n" +
            "stopmusic\n" +
            "insert [#]\n" +
            "Some Commands may not work",
            //Credits [1]
            "\n" +
            "Credits:\n" +
            "rakion99\n" +
            "Roblox\n" +
            "Africaus for pcall bypass\n" +
            "VOID for getobjects\n" +
            "DOGGO bypass/workaround for setting values on non-fe games\n" +
            "Eternal for RetCheck\n" +
            "AutisticBobby\n" +
            "ICE By: Josh() and Cosmology\n" +
                "and of course, Gray Entity for copying this off of Rakion99's client called Icememe, which you should check it out:\n" +
                "https://github.com/rakion99/IceMeme \n" +
                "Written by Gray Entity"
        };
    }
}