using System;
using System.Collections.Generic;


namespace dictionaries
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> toysSold = new Dictionary<string, int>() {
                {"Hot Wheels", 344},
                {"Legos", 763},
                {"Gaming Consoles", 551},
                {"Board Games", 298}
            };

            toysSold.Add("Bicycles", 87);


            //print to the console the keyvaluepair =  {"Board Games", 298}

            foreach (KeyValuePair<string, int> toy in toysSold)
            {
                Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
            }

            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("Y", "Yahoo");
            stocks.Add("WM", "Walmart");
            stocks.Add("GE", "General Electric");

            //To find a value in a Dictionary, you can use square bracket notation much like JavaScript object key lookups.
            string GM = stocks["GM"];

            // Console.WriteLine(GM); //General Motors


            //Next, create a list to hold stock purchases by an investor. The list will contain dictionaries(array of objects)
            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();


            purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 130.21 } });
            purchases.Add(new Dictionary<string, double>() { { "Y", 350.61 } });
            purchases.Add(new Dictionary<string, double>() { { "WM", 206.24 } });
            purchases.Add(new Dictionary<string, double>() { { "GE", 406.34 } });


            /* 
            Define a new Dictionary to hold the aggregated purchase information.
            - The key should be a string that is the full company name.
            - The value will be the total valuation of each stock
            */


            Dictionary<string, double> stockReport = new Dictionary<string, double>();


            /*
               Iterate over the purchases and record the valuation for each stock.
            */

            foreach (Dictionary<string, double> purchase in purchases) //iterates over the array of objects/list of dictionaries
            {
                foreach (KeyValuePair<string, double> currentpurchase in purchase) //iterates over the key and values of each dictionary
                {
                    {
                        string companyInitial = currentpurchase.Key;
                        string fullCompanyName = stocks[companyInitial]; //so here it is using square bracket notation to compare the key in stocks and the key in purchases

                        if (stockReport.ContainsKey(fullCompanyName))

                        {

                            //// If it does, update the total valuation
                            stockReport[fullCompanyName] += currentpurchase.Value;
                            //could also write it like this -- stockeReport[fullCompanyName] = stockReport[fullCompanyName] + transaction.Value

                        }
                        else
                        {

                            /*
                                If not, add the new key and set its value.
                                You have the value of "GE", so how can you look
                                the value of "GE" in the `stocks` dictionary
                                to get the value of "General Electric"?
                            */
                            stockReport.Add(fullCompanyName, currentpurchase.Value);


                        }
                    }
                }

                foreach (KeyValuePair<string, double> item in stockReport)
                {
                    Console.WriteLine($" {item.Key}'s stock is worth {item.Value}");
                }

            }

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });


            foreach (KeyValuePair<string, List<string>> idiom in idioms) //iterates over the key and values of each dictionary
            {

                // Console.WriteLine($" {idiom.Key}: {String.Join(" ", idiom.Value)}");
            }


            Dictionary<string, string> boyfriends = new Dictionary<string, string>();

            // Add Ariana's boyfriends to the boyfriends dictionary with the {key name, value boyfriend} ex. {Big Sean, boyfriend}

            boyfriends.Add("Pete Davidson", "boyfriend");
            boyfriends.Add(" Ricky Alvarez", "boyfriend");
            boyfriends.Add("Big Sean", "boyfriend");
            boyfriends.Add("Jai Brooks", "boyfriend");
            boyfriends.Add(" Nathan Sykes", "boyfriend");
            boyfriends.Add("Graham Phillips", "boyfriend");


            Dictionary<string, string> updatedBoyfriends = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> bae in boyfriends)
            {
                if (bae.Key == "Pete Davidson")
                {
                    updatedBoyfriends[bae.Key] = "ex-fiance";
                }
                else
                {
                    updatedBoyfriends[bae.Key] = "ex-boyfriend";
                }


            }

            foreach (KeyValuePair<string, string> bae in updatedBoyfriends)
            {
                Console.WriteLine($"Ariana's {bae.Key} is {bae.Value}");
            }
            // I want you to change the value of boyfriends to ex-boyfriends example: {Big Sean, ex-boyfriend}, if Pete Davidson change the value to ex-fiance ex {Pete Davidson, ex-fiance}



            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            List<Dictionary<string, string>> planetProbes = new List<Dictionary<string, string>>();
            planetProbes.Add(new Dictionary<string, string>() { { "BepiColombo", "Mercury" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Messenger", "Mercury" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Mariner 10", "Mercury" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Venus Express", "Venus" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Akatsuki", "Venus" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Satelite", "Earth" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Insight", "Mars" } });
            planetProbes.Add(new Dictionary<string, string>() { { "MAVEN", "Mars" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Mangalyaan", "Mars" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Cassini", "Jupiter" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Galileo", "Jupiter" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Cassini", "Saturn" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Hyugens", "Saturn" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Voyager 2", "Saturn" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Voyager 2", "Uranus" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Voyager 2", "Neptune" } });


            foreach (string planet in planetList)
            {
                List<string> matchingProbes = new List<string>();

                foreach (Dictionary<string, string> probe in planetProbes)
                {
                    foreach (KeyValuePair<string, string> pair in probe)
                        // Console.WriteLine($"key: {pair.Key} / value: {pair.Value}");

                        if (planet == pair.Value)
                        {
                            matchingProbes.Add(pair.Key);
                        }
                }
                Console.WriteLine($"{planet}: {String.Join(" ", matchingProbes)}");
            }


            /*   Define a Dictionary to represent a car. Each dictionary should have the following KeyValuePairs.

                    * Make
                    * Model
                    * Year
                    * Price

                Create 3 car dictionaries for 3 different car models */

            Dictionary<string, string> Ranger = new Dictionary<string, string>() {
                {"Make", "Saturn"},
                {"Model", "Ranger"},
                {"Year", "2004"},
                {"Price", "$2,400"},
        };

            Dictionary<string, string> Civic = new Dictionary<string, string>() {
                {"Make", "Honda"},
                {"Model", "Civic"},
                {"Year", "2010"},
                {"Price", "$5,400"},
        };

            Dictionary<string, string> Thunderbird = new Dictionary<string, string>() {
                {"Make", "Ford"},
                {"Model", "Juke"},
                {"Year", "2019"},
                {"Price", "$25,400"},
        };

            /* Create a car lot list.
               Add each car to the car lot.
               Iterate the car lot list and output all the details of each car dictionary
               arity-invokes the signature of a method / 
            */

            List<Dictionary<string, string>> carList = new List<Dictionary<string, string>>() {
                   Civic,
                   Thunderbird,
                   Ranger
               };

            foreach (Dictionary<string, string> car in carList)
            {
                foreach (KeyValuePair<string, string> specificCar in car)
                {
                    Console.WriteLine($"{specificCar.Key} {specificCar.Value}");
                }
            }

        }
    }
}
