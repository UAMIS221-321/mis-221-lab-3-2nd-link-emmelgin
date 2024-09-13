string enjoyLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoyLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails (stadium,game);

static string GetEnjoymentLevel(){
    Console.WriteLine("How much fun would you like to have watching college football?\n Boring\n Average\n Fun\n Epic\n");
    return Console.ReadLine();
}
static string GetStadiumRecommendation(string enjoyLevel){
    if(enjoyLevel == "Boring"){
        return("Neyland Stadium");
    }
    else if(enjoyLevel == "Average"){
        return("Jordan-Hare Stadium");
    }
    else if(enjoyLevel == "Fun"){
        return("Tiger Stadium");
    }
    else{
        return("Saban Field at Bryant-Denny Stadium");
    }
 }
    static string GetGameRecommendation(string stadium){
        if(stadium == "Neyland Stadium"){
            return ("the Kent State game");
        }
        else if(stadium == "Jordan-Hare Stadium"){
            return ("the Kentucky game");
        }
        else if(stadium == "Tiger Stadium"){
            return("the Alabama game");
        }
        else{
            return("the Auburn game");
        }   
}
    static void DisplayStadiumDetails(string stadium, string game){
        Console.WriteLine($"We recommend attending {game} at {stadium}.");
}
