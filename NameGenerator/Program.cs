public class NameGenerator{
    static void Main(){
        //Define base vars
        string[] listOfFirstnames, listOfLastnames;
        User user = new User();

        //Load name arrays from files
        string textFromFileFirstnames = File.ReadAllText("firstnamelist.csv");
        string textFromFileLastnames = File.ReadAllText("lastnamelist.csv");

        listOfFirstnames = textFromFileFirstnames.Split('\n');
        listOfLastnames = textFromFileLastnames.Split('\n'); 
        
        //Generate first name + last name
         Console.WriteLine("Name: " + user.GenerateFullname(listOfFirstnames, listOfLastnames));

        //Generate username
        Console.WriteLine("Username: " + user.GenerateUsername(user.firstname, user.lastname));

        //Generate password

    }
}

public class User{

    public string firstname, lastname, username, password;
    Random rand = new Random();

    public User(){
        firstname = "not defined";
        lastname = "not defined";
        username = "not defined";
    }

    public string GenerateFullname(String[] firstnameList, String[] lastnameList){
        firstname = firstnameList[rand.Next(0, 100)];
        lastname = lastnameList[rand.Next(0, 10)];
        return firstname + " " + lastname;
    }
    public string GenerateUsername(string firstname, string lastname){
        username =  ("" + firstname[0] + firstname[1] + lastname[0] + rand.Next(1, 99).ToString()).ToLower();
        return username;
    }
}