using System;
using System.Collections.Generic;
using System.Text;

namespace InfoBotLibrary
{
    public class UserLookup
    {
        public UserInfo GetUserInfo(string name)
        {
            UserInfo info = new UserInfo();
            info.Name = name;
            if (name == "SpyroJabber")
            {
                
                info.District = "Fantasy";
                info.Fact = "Is the CEO of PacificCorp";

            }
            else if (name == "CrashStudios")
            {
                
                info.District = "Futuristic";
                info.Fact = "Is the CEO of Yuio";
            }
            else if (name == "opsomor")
            {
                
                info.District = "Futuristic";
                info.Fact = "Is a meme. name : olie gender : male district : futuristic. hobby’s : jamming on my guitars , crying , meming on my keyboard , competitive gaming , being weird . Fun fact : I’m diabetic (type 1) and I’m ginger. Favourite colour : red and black Favourite song : any song that’s not country , rock , most pop ( except some k pop songs for the band ikon ) , anything that’s not from the band bts and any other band that is like that , classical music is epic and the best song of all time is the music from Star Wars in the cantina , also I love lotr soundtracks and lots of rap songs. Favourite games : minecraft , total war warhammer 2 , fortnite , overwatch...... also I live stream on twitch so make sure to check me out at twitchtv/opsomor. I also hate tik tok and I think anybody who uses it is a sinner. Favorite animal is a tiger. Favorite show is Scooby Doo, and favorite films are Hobbit and LOTR trilogies. 6ft and super skinny, so I think I should play Slenderman. I am British. I love watching Anime, and One Piece is another of my favorite shows. I hate the ending of basically every new Star Wars film. I can solve a rubix cube very quick ( I used to be able to ) in 9 secs. I also hold the world record for the fastest time to read 100 one piece chapters , I also hold the record for the most amount of changes to a fortnite sensitivity in 1 hour. I am a competitive badminton player and swimmer. I also play yugioh and win lots. I also do origami. I have a sick yugioh play Matt with golden edges, I have basically every minecraft book to ever exist, I also play warhammer irl and DnD, both the online game and irl. I hate reading any books that aren’t manga.";

            }
            else if (name == "Mravran")
            {
                
                info.District = "Futuristic";
                info.Fact = "Is French";

            }
            else if (name == "Silverfeather_SC")
            {
                
                info.District = "Oriental";
                info.Fact = "Is a cat";

            }
            else if (name == "MrBossMaker")
            {
                
                info.Fact = "Makes bosses. Whenever he makes bosses, you can hear this sound: rheea-urgh rheea-urgh rheea-urgh!";
            }
            else if (name == "ShadeTTV")
            {
                
                info.District = "Futuristic";
                info.Fact = "Is the best minecraft player ever, very humble though";
            }
            else if (name == "XDelta_SkullX")
            {
                
                info.District = "Futuristic";
                info.Fact = "Doesn't like to grind blocks and tries to find ways around it";

            }
            else if (name == "Little_c_Gaming")
            {
                
                info.District = "Fantasy";
                info.Fact = "Is a Pig that makes good YouTube videos";
            }
            else if (name == "walrus")
            {
                
                info.Fact = "A walrus is a large flippered marine mammal that lives in the arctic and subarctic seas of the northern hemisphere";
            }
            else if (name == "New Zealand")
            {
                
                info.Fact = "A country in the South Pacific Ocean. It is one of the best countries ever because it has little pollution, gorgeous mountains, unique biodiversity, lush pristine forests, and stunning coastlines.";
            }
            else if (name == "Spacey_Nerd")
            {
                
                info.Fact = "Good at making gold farms";
            }
            else if (name == "sbjyolo")
            {
                
                info.District = "Industrial";
                info.Fact = "Is a villager!";
            }
            else if (name == "Chulik_6")
            {
                
                info.District = "Sky";
                info.Fact = "Is a medium dog";
            }
            else if (name == "IChristianPlayzI")
            {
                
                info.District = "Medieval";
                info.Fact = "Is a great YouTuber";
            }
            else if (name == "Stanleyboy37")
            {
                
                info.District = "Industrial";
                info.Fact = "Is the Vice President of Yuio";
            }
            else if (name == "Rodrick950")
            {
               
                info.District = "Fantasy";
                info.Fact = "Bike";
            }
            else if (name == "EmptySoupCan")
            {
                
                info.District = "Medieval";
            }
            else if (name == "x_Maximus")
            {
                
                info.District = "Industrial";
                info.Fact = "'Waxiwus is a waaalrus!'";
            }
            else if (name == "x_Shadow01")
            {
                
                info.District = "Medieval";
            }
            else if (name == "talkingderp")
            {
                
                info.District = "Futuristic";
            }
            else if (name == "MayoOfficial")
            {
                info.Fact = "Likes country music and mayonnaise";
            }
            else if (name == "Yuio")
            {
                info.Fact = "One of the most powerful and successful corporations ever. Original headquarters were in season 1 Escadrillo subdistrict";
            }
            else if (name == "PacificCorp")
            {
                info.Fact = "The largest and most powerful corporation of all time. Original headquarters were in season 1 industrial district";
            }
            else if (name == "SpyroCraft")
            {
                info.District = "All";
                info.Fact = "Best SMP ever!";
            }
            else if (name == "French Fish")
            {
                info.District = "French";
                info.Fact = "A very intelligent fish that is from France and speaks French and has a mustache. It will answer any of your questions";
            }
            else if (name == "MPV2003")
            {
                info.Fact = "The most inactive person on discord and on the server";
            }
            else if (name == "uoh")
            {
                info.District = "N/A";
                info.Fact = "N/A";
            }
            else if (name == "KodakTX")
            {
                info.District = "Fantasy";
                info.Fact = "bike";
            }
            else if (name == "Dragonman")
            {
                info.Fact = "The best superhero from season 1 and totally not spyrojabber";
            }
            else if (name == "chen7_")
            {
                info.District = "Industrial/Fantasy";
                info.Fact = "Loves cows";
            }
            else if (name == "Australia")
            {
                info.Fact = "Tshhhh! COW!";
            }
            else if (name == "Ayciate")
            {
                info.Fact = "Says wb and ty to himself and was the opsomor of skuxMC. Also a really cool person";
            }
            else
            {
                info.ErrorMessage = "What the heck is that???";
            }
            return info;
        }
    }
}
