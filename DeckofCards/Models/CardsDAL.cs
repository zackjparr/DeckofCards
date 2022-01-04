using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckofCards.Models
{
    public class CardsDAL
    {
        public Draw GetCards()
        {
            string url = "https://deckofcardsapi.com/api/deck/new/";

            //Next we need to create our request 
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //Next if your API needs any kind of login or key, that may go here 
            //SWAPI doesn't need anything so we're good
            //Now we're ready to send off our request and grab the server's response 
            //Inside our response, the resulting data lives 
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Pull the result into a stream reader which will then give us a string 
            StreamReader rd = new StreamReader(response.GetResponseStream());

            //Grab our response string - read to end starts at the top of our response file and returns each line 
            //until it hits the end. 
            string result = rd.ReadToEnd();

            //This line converts our JSON string into a person object automatically 
            Draw d = JsonConvert.DeserializeObject<Draw>(result);

            //Later we'll convert our string into a model which makes it much easier to use for .net
            return d;
        }

        public Draw Draw5Cards()
        {
            string url = $"https://deckofcardsapi.com/api/deck/new/draw/?count=5";

            //Next we need to create our request 
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //Next if your API needs any kind of login or key, that may go here 
            //SWAPI doesn't need anything so we're good
            //Now we're ready to send off our request and grab the server's response 
            //Inside our response, the resulting data lives 
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Pull the result into a stream reader which will then give us a string 
            StreamReader rd = new StreamReader(response.GetResponseStream());

            //Grab our response string - read to end starts at the top of our response file and returns each line 
            //until it hits the end. 
            string result = rd.ReadToEnd();

            //This line converts our JSON string into a person object automatically 
            Draw d = JsonConvert.DeserializeObject<Draw>(result);

            //Later we'll convert our string into a model which makes it much easier to use for .net
            return d;
        }
    }
}
