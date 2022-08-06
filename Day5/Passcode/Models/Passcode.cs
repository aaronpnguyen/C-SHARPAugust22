namespace Passcodes.Models;

public class Passcode
{
    public string createPassword() {
        string upperList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerList = "abcdefghijklmnopqrstuvwxyz";
        string numList = "123456789";
        string specialList = "!@#$%^&*()-=/?<>";
        string password = "";
        Random random = new Random();
        for (int i = 0; i < 14; i++)
        {
            int num = random.Next(4);
            if (num == 0) password += upperList[random.Next(upperList.Length)];
            if (num == 1) password += lowerList[random.Next(lowerList.Length)];
            if (num == 2) password += numList[random.Next(numList.Length)];
            if (num == 3) password += specialList[random.Next(specialList.Length)];
        }
        Console.WriteLine(password);
        return password;
    }
}
