﻿namespace RPG_ConsoleGame.Core.Factories
{
    using Characters;
    using Interfaces;
    using Map;

    public class PlayerFactory : IPlayerFactory
    {
         public IPlayer CreateHuman(Position position, char objectSymbol, string name, PlayerClass race)
         {
            var player = new Player(position, objectSymbol, name, race);

            return player;
        }
    }
}
