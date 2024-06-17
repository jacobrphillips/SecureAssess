using System;
using API.Entities;

namespace API.Extensions
{
    public static class SampleExtensions
    {
        public static int CalculateSamples(this Sample sample)
        {
            switch (sample.SampleType)
            {
                case SampleType.ExternalIP:
                    return sample.Quantity;

                case SampleType.Server:
                case SampleType.Workstation:
                case SampleType.Mobile:
                    return CalculateDeviceSamples(sample.Quantity);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static int CalculateDeviceSamples(int quantity)
        {
            if (quantity == 1)
            {
                return 1;
            }
            else if (quantity >= 2 && quantity <= 5)
            {
                return 2;
            }
            else if (quantity >= 6 && quantity <= 19)
            {
                return 3;
            }
            else if (quantity >= 20 && quantity <= 60)
            {
                return 4;
            }
            else if (quantity >= 61)
            {
                return 5;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than 0.");
            }
        }
    }
}
