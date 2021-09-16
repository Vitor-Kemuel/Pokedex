using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using pokemon.Models;

namespace pokemon.Controllers
{
    public class HomeController : Controller
    {
        private List<Pokemon> getPokemons(){
            List<Pokemon> pokemons = new List<Pokemon>();

            Pokemon pokemon01 = new Pokemon();
            pokemon01.Id = 1;
            pokemon01.Img = "~/img/001.png";
            pokemon01.Nome = "Bulbasaur";
            pokemon01.Tipo = "Glass";

            Pokemon pokemon02 = new Pokemon();
            pokemon02.Id = 2;
            pokemon02.Img = "~/img/002.png";
            pokemon02.Nome = "Ivysaur";
            pokemon02.Tipo = "Glass";

            Pokemon pokemon03 = new Pokemon();
            pokemon03.Id = 3;
            pokemon03.Img = "~/img/003.png";
            pokemon03.Nome = "Venusaur";
            pokemon03.Tipo = "Glass";

            Pokemon pokemon04 = new Pokemon();
            pokemon04.Id = 4;
            pokemon04.Img = "~/img/004.png";
            pokemon04.Nome = "Charmander";
            pokemon04.Tipo = "Fire";

            Pokemon pokemon05 = new Pokemon();
            pokemon05.Id = 5;
            pokemon05.Img = "~/img/005.png";
            pokemon05.Nome = "Charmeleon";
            pokemon05.Tipo = "Fire";

            Pokemon pokemon06 = new Pokemon();
            pokemon06.Id = 6;
            pokemon06.Img = "~/img/006.png";
            pokemon06.Nome = "Charizard";
            pokemon06.Tipo = "Fire";

            Pokemon pokemon07 = new Pokemon();
            pokemon07.Id = 7;
            pokemon07.Img = "~/img/007.png";
            pokemon07.Nome = "Squirtle";
            pokemon07.Tipo = "Water";

            Pokemon pokemon08 = new Pokemon();
            pokemon08.Id = 8;
            pokemon08.Img = "~/img/008.png";
            pokemon08.Nome = "Wartortle";
            pokemon08.Tipo = "Wather";
            
            Pokemon pokemon09 = new Pokemon();
            pokemon09.Id = 9;
            pokemon09.Img = "~/img/009.png";
            pokemon09.Nome = "Blastoise";
            pokemon09.Tipo = "Water";
            
            Pokemon pokemon10 = new Pokemon();
            pokemon10.Id = 10;
            pokemon10.Img = "~/img/010.png";
            pokemon10.Nome = "Caretpie";
            pokemon10.Tipo = "Bug";
            
            Pokemon pokemon11 = new Pokemon();
            pokemon11.Id = 11;
            pokemon11.Img = "~/img/011.png";
            pokemon11.Nome = "Metapod";
            pokemon11.Tipo = "Bug";
            
            Pokemon pokemon12 = new Pokemon();
            pokemon12.Id = 12;
            pokemon12.Img = "~/img/012.png";
            pokemon12.Nome = "Buterfree";
            pokemon12.Tipo = "Bug";
            
            Pokemon pokemon13 = new Pokemon();
            pokemon13.Id = 13;
            pokemon13.Img = "~/img/013.png";
            pokemon13.Nome = "Weedle";
            pokemon13.Tipo = "Bug";
            
            Pokemon pokemon14 = new Pokemon();
            pokemon14.Id = 14;
            pokemon14.Img = "~/img/014.png";
            pokemon14.Nome = "Kakuna";
            pokemon14.Tipo = "Bug";
            
            Pokemon pokemon15 = new Pokemon();
            pokemon15.Id = 15;
            pokemon15.Img = "~/img/015.png";
            pokemon15.Nome = "Beedrill";
            pokemon15.Tipo = "Bug";
            
            Pokemon pokemon16 = new Pokemon();
            pokemon16.Id = 16;
            pokemon16.Img = "~/img/016.png";
            pokemon16.Nome = "Pidgey";
            pokemon16.Tipo = "Flying";
            
            Pokemon pokemon17 = new Pokemon();
            pokemon17.Id = 17;
            pokemon17.Img = "~/img/010.png";
            pokemon17.Nome = "Pidgeotto";
            pokemon17.Tipo = "FLying";
            
            Pokemon pokemon18 = new Pokemon();
            pokemon18.Id = 18;
            pokemon18.Img = "~/img/018.png";
            pokemon18.Nome = "Pidgeot";
            pokemon18.Tipo = "Flying";
            
            Pokemon pokemon19 = new Pokemon();
            pokemon19.Id = 19;
            pokemon19.Img = "~/img/019.png";
            pokemon19.Nome = "Rattata";
            pokemon19.Tipo = "Normal";
            
            Pokemon pokemon20 = new Pokemon();
            pokemon20.Id = 20;
            pokemon20.Img = "~/img/020.png";
            pokemon20.Nome = "Raticate";
            pokemon20.Tipo = "Normal";
            
            Pokemon pokemon21 = new Pokemon();
            pokemon21.Id = 21;
            pokemon21.Img = "~/img/021.png";
            pokemon21.Nome = "Spearow";
            pokemon21.Tipo = "Flying";
            
            Pokemon pokemon22 = new Pokemon();
            pokemon22.Id = 22;
            pokemon22.Img = "~/img/022.png";
            pokemon22.Nome = "Fearow";
            pokemon22.Tipo = "Flying";
            
            Pokemon pokemon23 = new Pokemon();
            pokemon23.Id = 23;
            pokemon23.Img = "~/img/023.png";
            pokemon23.Nome = "Ekans";
            pokemon23.Tipo = "Poison";
            
            Pokemon pokemon24 = new Pokemon();
            pokemon24.Id = 24;
            pokemon24.Img = "~/img/024.png";
            pokemon24.Nome = "Arbok";
            pokemon24.Tipo = "Poison";
            
            Pokemon pokemon25 = new Pokemon();
            pokemon25.Id = 25;
            pokemon25.Img = "~/img/025.png";
            pokemon25.Nome = "Pikachu";
            pokemon25.Tipo = "Eletric";
            
            Pokemon pokemon26 = new Pokemon();
            pokemon26.Id = 26;
            pokemon26.Img = "~/img/026.png";
            pokemon26.Nome = "Raichu";
            pokemon26.Tipo = "Eletric";
            
            Pokemon pokemon27 = new Pokemon();
            pokemon27.Id = 27;
            pokemon27.Img = "~/img/027.png";
            pokemon27.Nome = "Sandshrew";
            pokemon27.Tipo = "Ground";
            
            Pokemon pokemon28 = new Pokemon();
            pokemon28.Id = 28;
            pokemon28.Img = "~/img/028.png";
            pokemon28.Nome = "Sandslash";
            pokemon28.Tipo = "Ground";
            
            Pokemon pokemon29 = new Pokemon();
            pokemon29.Id = 29;
            pokemon29.Img = "~/img/029.png";
            pokemon29.Nome = "Nidoran♀";
            pokemon29.Tipo = "Poison";
            
            Pokemon pokemon30 = new Pokemon();
            pokemon30.Id = 30;
            pokemon30.Img = "~/img/030.png";
            pokemon30.Nome = "Nidorana";
            pokemon30.Tipo = "Poison";
            
            Pokemon pokemon31 = new Pokemon();
            pokemon31.Id = 31;
            pokemon31.Img = "~/img/031.png";
            pokemon31.Nome = "Nidorana";
            pokemon31.Tipo = "Poison";
            
            Pokemon pokemon32 = new Pokemon();
            pokemon32.Id = 32;
            pokemon32.Img = "~/img/032.png";
            pokemon32.Nome = "Nidorana";
            pokemon32.Tipo = "Poison";
            
            Pokemon pokemon33 = new Pokemon();
            pokemon33.Id = 33;
            pokemon33.Img = "~/img/033.png";
            pokemon33.Nome = "Nidorana";
            pokemon33.Tipo = "Poison";
            
            Pokemon pokemon34 = new Pokemon();
            pokemon34.Id = 34;
            pokemon34.Img = "~/img/034.png";
            pokemon34.Nome = "Nidorana";
            pokemon34.Tipo = "Poison";
            
            Pokemon pokemon35 = new Pokemon();
            pokemon35.Id = 35;
            pokemon35.Img = "~/img/035.png";
            pokemon35.Nome = "Nidorana";
            pokemon35.Tipo = "Poison";
            
            Pokemon pokemon36 = new Pokemon();
            pokemon36.Id = 36;
            pokemon36.Img = "~/img/036.png";
            pokemon36.Nome = "Nidorana";
            pokemon36.Tipo = "Poison";
            
            Pokemon pokemon37 = new Pokemon();
            pokemon37.Id = 37;
            pokemon37.Img = "~/img/037.png";
            pokemon37.Nome = "Nidorana";
            pokemon37.Tipo = "Poison";
            
            Pokemon pokemon38 = new Pokemon();
            pokemon38.Id = 38;
            pokemon38.Img = "~/img/038.png";
            pokemon38.Nome = "Nidorana";
            pokemon38.Tipo = "Poison";
            
            Pokemon pokemon39 = new Pokemon();
            pokemon39.Id = 39;
            pokemon39.Img = "~/img/039.png";
            pokemon39.Nome = "Nidorana";
            pokemon39.Tipo = "Poison";
            
            Pokemon pokemon40 = new Pokemon();
            pokemon40.Id = 40;
            pokemon40.Img = "~/img/040.png";
            pokemon40.Nome = "Nidorana";
            pokemon40.Tipo = "Poison";

            pokemons.Add(pokemon01);
            pokemons.Add(pokemon02);
            pokemons.Add(pokemon03);
            pokemons.Add(pokemon04);
            pokemons.Add(pokemon05);
            pokemons.Add(pokemon06);
            pokemons.Add(pokemon07);
            pokemons.Add(pokemon08);
            pokemons.Add(pokemon09);
            pokemons.Add(pokemon10);
            pokemons.Add(pokemon11);
            pokemons.Add(pokemon12);
            pokemons.Add(pokemon13);
            pokemons.Add(pokemon14);
            pokemons.Add(pokemon15);
            pokemons.Add(pokemon16);
            pokemons.Add(pokemon17);
            pokemons.Add(pokemon18);
            pokemons.Add(pokemon19);
            pokemons.Add(pokemon20);
            pokemons.Add(pokemon21);
            pokemons.Add(pokemon22);
            pokemons.Add(pokemon23);
            pokemons.Add(pokemon24);
            pokemons.Add(pokemon25);
            pokemons.Add(pokemon26);
            pokemons.Add(pokemon27);
            pokemons.Add(pokemon28);
            pokemons.Add(pokemon29);
            pokemons.Add(pokemon30);
            pokemons.Add(pokemon31);
            pokemons.Add(pokemon32);
            pokemons.Add(pokemon33);
            pokemons.Add(pokemon34);
            pokemons.Add(pokemon35);
            pokemons.Add(pokemon36);
            pokemons.Add(pokemon37);
            pokemons.Add(pokemon38);
            pokemons.Add(pokemon39);
            pokemons.Add(pokemon40);

            return pokemons;
        }
        public ActionResult Index()
        {
            return View(getPokemons());
        }
        public ActionResult Pokedex()
        {
            return View(getPokemons());
        }
    }
}
