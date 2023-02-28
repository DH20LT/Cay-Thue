namespace CayThue.Models.Games;

public interface IGameRep
{
    Game GetGame(string id);
    Game GetGameByCode(string code);
}