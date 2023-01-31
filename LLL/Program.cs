// See https://aka.ms/new-console-template for more information

public class Lasagna {
    // Init vars
    // Defaults
    int overallOvenTime = 40;
    int PerLayerTime = 2;

    //define methods
    public int ExpectedMinutesInOven(){
        //Default expectation of 40 mins overall
        return overallOvenTime;
    }
    public int RemainingMinutesInOven(int timeElapsed){
        //calculate time remaining
        return ExpectedMinutesInOven() - timeElapsed;
    }
    public int PreparationTimeInMinutes(int layerAmount){
        //per layer * time per layer
        return layerAmount*PerLayerTime;
    }
    public int ElapsedTimeInMinutes(int numberOfLayers, int totalTimeInOven){
        //sum of prep time and minutes in oven so far
        return PreparationTimeInMinutes(numberOfLayers) + totalTimeInOven;
    }
}

class LLL{
    static void Main(){
        Lasagna lasagna = new Lasagna(); 
        Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20).ToString());  
    }
}

