﻿using Microsoft.Extensions.Configuration;

namespace MyProject.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private readonly IConfiguration configuration;

        public Greeter(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string GetMessageOfTheDay()
        {
            return this.configuration["Greeting"];
        }
    }
}