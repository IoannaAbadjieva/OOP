﻿namespace Easter.Models.Eggs
{
    using System;

    using Contracts;
    using Utilities.Messages;
    

    public class Egg : IEgg
    {
        private const int EnergyDecreasementStep = 10;

        private string name;
        private int energyRequired;

        public Egg(string name, int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEggName);
                }

                this.name = value;
            }
        }

        public int EnergyRequired
        {
            get => this.energyRequired;

            private set
            {
                if (value < 0)
                {
                    this.energyRequired = 0;
                }

                this.energyRequired = value;
            }
        }

        public void GetColored()
        {
            this.EnergyRequired -= EnergyDecreasementStep;
        }

        public bool IsDone()
        => this.EnergyRequired == 0;
    }
}
