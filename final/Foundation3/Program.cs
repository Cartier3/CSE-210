using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4568 West Chester Road", "Dallas", "Texas", "USA");
        Address address2 = new Address("54 Peace Road", "Topeka", "Kansas", "USA");
        Address address3 = new Address("777 Sun Way", "Mesa", "Arizona", "USA");

        Lecture lecture1 = new Lecture("The Rise of Empires", "Albert Smith will discuss the rise of the biggest empires to ever rule the Earth. He will discuss the aspects of what made their empire's structure so strong and each period of their power.", "2-14-2025", "3:00pm", address1, "Albert Smith", 300);

        Reception reception1 = new Reception("Evan and Kimberlee Wedding Reception", "Come and say congratulations to Evan and Kimberlee at their wedding reception this Tuesday at 5pm! A Hawaiian Feast will be provided for the main course along with many different Hawaiian desserts!", "04-22-2025", "5:00pm", address2, "BradleyCooper@gmail.com");

        OutdoorGatherings outdoorGath1 = new OutdoorGatherings("Hansen Family Christmas Party", "Join us for a festive gathering in our backyard this Christmas Eve!", "12-24-2025", "9:00pm", address3, "55 Degrees Farenheit Cloudy");

        lecture1.DisplayStandardDetails();
        lecture1.DisplayLecFullDetails();
        lecture1.DisplayLecShortDesc();

        reception1.DisplayStandardDetails();
        reception1.DisplayRecFullDetails();
        reception1.DisplayRecShortDesc();

        outdoorGath1.DisplayStandardDetails();
        outdoorGath1.DisplayOutdFullDetails();
        outdoorGath1.DisplayOutdShortDesc();

    }
}