using System;

namespace HelloWorld.Models
{
    public class GreetingModels
    {
        public class Greeting
        {
            private String[] greeting = new String[] { "Hello World!", "Zdravei Sviat!" };
            public String getGreeting(String option)
            {
                switch (option)
                {
                    case "English":
                        return greeting[0];
                    case "Bulgarian":
                        return greeting[1];
                    default:
                        return "Please specify a language - English or Bulgarian";
                }
            }
            public String getNameGreeting(String name)
            {
                if (name != null)
                {
                    return "Hello "+name;
                }
                else
                {
                    return "Who might you be?";
                }
            }
            
        }
    }
}
